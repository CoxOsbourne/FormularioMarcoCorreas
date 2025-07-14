using System;
using System.Runtime;
using System.Globalization;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Catalogs;
using Tekla.Structures.Datatype;
using Tekla.Structures.Dialog;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Plugins;
using static Tekla.Structures.Filtering.Categories.PartFilterExpressions;
using static Tekla.Structures.Filtering.Categories.ReinforcingBarFilterExpressions;
using TSG = Tekla.Structures.Geometry3d;
using TSM = Tekla.Structures.Model;

namespace FormularioMarcoCorreas
{
    public partial class MainForm : Tekla.Structures.Dialog.PluginFormBase
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OkApplyModifyGetOnOffCancel_OkClicked(object sender, EventArgs e)
        {
            this.Apply();
            this.Close();
        }

        private void OkApplyModifyGetOnOffCancel_ApplyClicked(object sender, EventArgs e)
        {
            this.Apply();
        }

        private void OkApplyModifyGetOnOffCancel_ModifyClicked(object sender, EventArgs e)
        {
            this.Modify();
        }

        private void OkApplyModifyGetOnOffCancel_GetClicked(object sender, EventArgs e)
        {
            this.Get();
        }

        private void OkApplyModifyGetOnOffCancel_OnOffClicked(object sender, EventArgs e)
        {
            this.ToggleSelection();
        }

        private void OkApplyModifyGetOnOffCancel_CancelClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ParametersTabPage_Click(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void profileCatalogFrameSelectClicked(object sender, EventArgs e)
        {
            profileCatalogFrame.SelectedProfile = textBoxFrameProfile.Text;
        }

        private void profileCatalogFrameSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxFrameProfile,profileCatalogFrame.SelectedProfile);
        }

        private void materialCatalogFrameSelectClicked(object sender, EventArgs e)
        {
            materialCatalogFrame.SelectedMaterial=textBoxFrameMaterial.Text;
        }

        private void materialCatalogFrameSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxFrameMaterial,materialCatalogFrame.SelectedMaterial);
        }

        private void buttonCreateFrame_Click(object sender, EventArgs e)
        {
            this.Get();   // recoge valores actuales del formulario
            this.Apply();
            try
            {
                // Leer ancho (X) y largo (Y) del marco
                if (!double.TryParse(textBoxFrameWidth.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double widthFrame))
                {
                    widthFrame = 6000.0; // eje X
                }

                if (!double.TryParse(textBoxFrameLength.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double lengthFrame))
                {
                    lengthFrame = 4000.0; // eje Y
                }

                //Obtención de dimensiones de perfiles de marco y correas
                //Gathering dimensions of frame and purlin profiles
                string profileFrame = textBoxFrameProfile.Text;
                string materialFrame = textBoxFrameMaterial.Text;
                string profileCorrea = textBoxProfileCorrea.Text;
                string materialCorrea=textBoxCorreaMaterial.Text;
                double alturaPlano = 3000;

                // Calcular offset en Z para alinear alas superiores
                //z-axis offset to align upper beam wings
                (double hMarco, _) = GetProfileDimensions(profileFrame);
                (double hCorrea, _) = GetProfileDimensions(profileCorrea);
                double offsetCorreas = hMarco - hCorrea;
                
                TSM.Model model = new TSM.Model();

                // Puntos del marco con eje X = widthFrame, eje Y = lengthFrame
                //Frame points . x-axis=widthFrame, y-axis = lengthFrame
                TSG.Point point1 = new TSG.Point(0, 0, 0);
                TSG.Point point2 = new TSG.Point(widthFrame, 0, 0);
                TSG.Point point3 = new TSG.Point(widthFrame, lengthFrame, 0);
                TSG.Point point4 = new TSG.Point(0, lengthFrame, 0);
                
                CrearMarcoConBiseles(widthFrame, lengthFrame, profileFrame, materialFrame);
                CrearCorreas(widthFrame, lengthFrame, profileCorrea, materialCorrea, offsetCorreas);
                CrearMarcoElevadoConCorreas(widthFrame,lengthFrame,profileFrame, materialFrame,alturaPlano,offsetCorreas,profileCorrea,materialCorrea);
                model.CommitChanges();
                //MessageBox.Show("Marco creado correctamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el marco: " + ex.Message);
            }
        }
        private void CrearMarcoConBiseles(double widthFrame, double lengthFrame, string profile, string material)
        {
            (double h, double b) = GetProfileDimensions(profile);
            //double halfB = profileWidth / 2.0;

            //Uso puntos distintos para las vigas, el marco en sí y los puntos de los planos de corte. Los puntos de los planos de corte son los mismos que los del marco.
            //I use different points for beams, the frame itself and cutting planes. The cutting planes' points are the same as frame points
            TSM.Model model = new TSM.Model();
            TSG.Point point1=new Point(0, 0, 0);
            TSG.Point point1VigaH=new Point(point1.X-(b/2), point1.Y,point1.Z);
            TSG.Point point1VigaV = new Point(point1.X, point1.Y-(b/2), point1.Z);
            //TSG.Point point1Cut = new Point(-b/2,-b/2,0);
            TSG.Point point2=new Point(widthFrame, 0, 0);
            TSG.Point point2VigaH = new Point(point2.X+(b/2), point2.Y, point2.Z);
            TSG.Point point2VigaV = new Point(point2.X, point2.Y - (b / 2), point2.Z);
            //TSG.Point point2Cut = new Point(widthFrame+(b/2),-b/2,0);
            TSG.Point point3 = new Point(widthFrame,lengthFrame,0);
            TSG.Point point3VigaH =new Point(point3.X+(b/2),point3.Y,point3.Z);
            TSG.Point point3VigaV = new Point(point3.X, point3.Y + (b/2), point3.Z);
            TSG.Point point4 = new Point(0, lengthFrame, 0);
            TSG.Point point4VigaH = new Point(point4.X-(b/2), point4.Y, 0);
            TSG.Point point4VigaV = new Point(point4.X, point4.Y+(b/2), 0);
            // VIGA INFERIOR, horizontal
            //TSG.Point point1 = new TSG.Point(-halfB, 0, 0);
            //TSG.Point point2 = new TSG.Point(widthFrame + halfB, 0, 0);
            TSM.ModelObject viga1 = CreateBeam(point1VigaH, point2VigaH, profile, material,"VIGA",0);
            InsertBevelCut(viga1, point1, new TSG.Vector(1, 1, 0), new TSG.Vector(0,0,-1));
            InsertBevelCut(viga1, point2, new TSG.Vector(-1, 1, 0), new TSG.Vector(0,0,1));

            // VIGA SUPERIOR, horizontal
            //TSG.Point point4 = new TSG.Point(-halfB, lengthFrame, 0);
            //TSG.Point point3 = new TSG.Point(widthFrame + halfB, lengthFrame, 0);
            TSM.ModelObject viga3 = CreateBeam(point3VigaH, point4VigaH, profile, material, "VIGA",0);
            InsertBevelCut(viga3, point3, new TSG.Vector(-1, -1, 0), new TSG.Vector(0,0,-1));
            InsertBevelCut(viga3, point4, new TSG.Vector(1, -1, 0), new TSG.Vector(0,0,1));

            // VIGA IZQUIERDA (LEFT BEAM), vertical
            //TSG.Point point1 = new TSG.Point(0, -halfB, 0);
            //TSG.Point point4 = new TSG.Point(0, lengthFrame + halfB, 0);
            TSM.ModelObject viga4 = CreateBeam(point1VigaV, point4VigaV, profile, material, "VIGA", 0);
            InsertBevelCut(viga4, point1, new TSG.Vector(1, 1, 0), new TSG.Vector(0, 0, +1));
            InsertBevelCut(viga4, point4, new TSG.Vector(1, -1, 0), new TSG.Vector(0, 0, -1));

            // VIGA DERECHA (RIGHT BEAM), vertical
            //TSG.Point point2 = new TSG.Point(widthFrame, -halfB, 0);
            //TSG.Point point3 = new TSG.Point(widthFrame, lengthFrame + halfB, 0);
            TSM.ModelObject viga2 = CreateBeam(point2VigaV, point3VigaV, profile, material, "VIGA", 0);
            InsertBevelCut(viga2, point2, new TSG.Vector(-1, 1, 0), new TSG.Vector(0,0,-1));
            InsertBevelCut(viga2, point3, new TSG.Vector(-1, -1, 0), new TSG.Vector(0, 0, +1));
            

            model.CommitChanges();
        }


        private TSM.ModelObject CreateBeam(TSG.Point start, TSG.Point end, string profile, string material, string name, double offsetZ)
        {
            TSM.Beam beam = new TSM.Beam(start, end);

            beam.Profile.ProfileString = profile;
            beam.Material.MaterialString = material;
            beam.Class = "2";
            beam.Name = name;

            beam.StartPoint.X = start.X;
            beam.StartPoint.Y = start.Y;
            beam.StartPoint.Z = start.Z;
            beam.StartPointOffset.Dz = offsetZ;

            beam.EndPoint.X = end.X;
            beam.EndPoint.Y = end.Y;
            beam.EndPoint.Z = end.Z;

            //Necesitamos el offset, solo por las correas
            //Unfortunately offset is needed for purlins
            beam.EndPointOffset.Dz = offsetZ;
            //beam.Position.DepthOffset.

            beam.Position.Rotation = TSM.Position.RotationEnum.TOP;
            beam.Position.Plane = TSM.Position.PlaneEnum.MIDDLE;
            beam.Position.Depth = TSM.Position.DepthEnum.FRONT;

            if (!beam.Insert())
            {
                Console.WriteLine($"Error: no se pudo insertar la viga entre ({start.X},{start.Y},{start.Z}) y ({end.X},{end.Y},{end.Z}).");
            }

            return beam;
        }
        private (double profileHeight, double profileWidth) GetProfileDimensions(string profileName)
        {
            // Insertar una viga ficticia. La usamos solo para sacar los datos del perfil.
            //Fake beam insertion. Used only to get profile data.
            TSM.Beam tempBeam = new TSM.Beam(new TSG.Point(0, 0, 0), new TSG.Point(1000, 0, 0))
            {
                Profile = { ProfileString = profileName },
                Material = { MaterialString = "S235JR" }, // Material cualquiera
                Class = "99"
            };

            if (!tempBeam.Insert())
            {
                throw new Exception("No se pudo insertar el perfil temporal.");
            }

            double profileHeight = 0.0;
            double profileWidth = 0.0;

            bool gotHeight = tempBeam.GetReportProperty("HEIGHT", ref profileHeight);
            bool gotWidth = tempBeam.GetReportProperty("WIDTH", ref profileWidth);

            // Eliminar el beam temporal
            //Temporal beam deletion
            tempBeam.Delete();

            if (!gotHeight || !gotWidth)
            {
                throw new Exception($"No se pudieron obtener HEIGHT/WIDTH para el perfil '{profileName}'.");
            }

            return (profileHeight, profileWidth);
        }
        private void CrearCorreas(double widthFrame, double lengthFrame, string profile, string material, double offsetCorreas)
        {
            TSM.Model model = new TSM.Model();

            int cantidadCorreas = (int)(lengthFrame / 1000.0);

            for (int i = 1; i < cantidadCorreas; i++)
            {
                double y = i * 1000;

                TSG.Point start = new TSG.Point(0, y,0);
                TSG.Point end = new TSG.Point(widthFrame, y,0);

                CreateBeam(start, end, profile, material, "CORREA", offsetCorreas);
            }

            model.CommitChanges();
        }
        private void InsertBevelCut(TSM.ModelObject beam, TSG.Point origin, TSG.Vector vector1, TSG.Vector vector2)
        {
            TSM.Plane cutPlane = new TSM.Plane
            {
                //¿Qué hace falta para tener un plano? Un punto y 2 vectores
                //What do you need to generate a plane? A point and 2 vectors
                Origin = origin,
                AxisX = vector1,
                AxisY = vector2,
                //AxisY = new TSG.Vector(0, 0, -1) // dirección vertical
            };

            TSM.CutPlane bevel = new TSM.CutPlane
            {
                Father = beam,
                Plane = cutPlane
            };

            if (!bevel.Insert())
            {
                Console.WriteLine($"No se pudo insertar plano de corte en {origin}");
            }
        }

        //cambio de plano de trabajo
        //change of workplane
        private void CrearMarcoElevadoConCorreas(double widthFrame, double lengthFrame, string profile, string material, double alturaZ, double offsetCorreas, string profileCorrea, string materialCorrea)
        {
            TSM.Model model = new TSM.Model();
            WorkPlaneHandler wph = model.GetWorkPlaneHandler();

            // Guardar el plano de trabajo actual
            TransformationPlane originalPlane = wph.GetCurrentTransformationPlane();

            // Crear nuevo plano trasladado en Z
            TransformationPlane planoElevado = new TransformationPlane(
                new CoordinateSystem(
                    new TSG.Point(0, 0, alturaZ),       // origen nuevo plano
                    new TSG.Vector(1, 0, 0),            // eje X igual
                    new TSG.Vector(0, 1, 0)             // eje Y igual
                )
            );

            // Cambiar al nuevo plano
            wph.SetCurrentTransformationPlane(planoElevado);

            // Insertar marco en el nuevo plano
            CrearMarcoConBiseles(widthFrame, lengthFrame, profile, material);
            CrearCorreas(widthFrame, lengthFrame, profileCorrea, materialCorrea, offsetCorreas);

            // Restaurar plano original
            wph.SetCurrentTransformationPlane(originalPlane);
        }


        private void profileCatalogCorreaSelectClicked(object sender, EventArgs e)
        {
            profileCatalogCorrea.SelectedProfile=textBoxProfileCorrea.Text; 
        }

        private void profileCatalogCorreaSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxProfileCorrea, profileCatalogCorrea.SelectedProfile);
        }

        private void profileCatalogFrame_Load(object sender, EventArgs e)
        {

        }

        private void materialCatalogCorreaSelectClicked(object sender, EventArgs e)
        {
            materialCatalogCorrea.SelectedMaterial=textBoxCorreaMaterial.Text;
        }

        private void materialCatalogCorreaSelectionDone(object sender, EventArgs e)
        {
            SetAttributeValue(textBoxCorreaMaterial,materialCatalogCorrea.SelectedMaterial);
        }
    }
}