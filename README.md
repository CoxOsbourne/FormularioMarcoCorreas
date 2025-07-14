Plugin para Tekla Structures, usando la plantilla ModelPlugin. Con este plugin, creas un marco con correas introduciendo datos en un formulario. Está pensado para perfiles en i.
Lo interesante aquí es usar el offset para alinear las alas de las correas con las del marco, más la generación de planos de corte para hacer los cortes biselados de las vigas del marco.
Como en otros plugins, la magia está en el MainForm. En ModelPlugin pongo las variables del formulario y fuera. Mira el código.

Tekla Structures plugin using ModelPlugin template. With this plugin, you can create a frame with purlins typing some data in a form. It's intended for I (i) profiles.
The interesting code bits are cutting plane creation, and making the offset to align purlins with frame beams.
Like in other plugins, the magic happens inside MainForm. ModelPlugin only contains form variables used. Just look at the code.
