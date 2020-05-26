# tpn6-SimonHolmquist
tpn6-SimonHolmquist created by GitHub Classroom

¿String es una tipo por valor o un tipo por referencia?

String es un tipo por referencia.

¿Qué secuencias de escape tiene el tipo string?

\ '- comilla simple (0x0027)
\ "- comillas dobles (0x0022)
\\ - barra invertida (0x005C)
\ 0 - nulo (0x0000)
\ a - alerta (0x0007)
\ b - retroceso (0x0008)
\ f - alimentación de formulario (0x000C)
\ n - nueva línea (0x000A)
\ r - retorno de carro (0x000D)
\ t - pestaña horizontal (0x0009)
\ v - pestaña vertical (0x000B)
\ u0000 - \ uFFFF - Carácter Unicode
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable)
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos)

¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?

En las cadenas textuales las secuencias de escape no se procesan, lo que facilita la escritura de, por ejemplo, un nombre de archivo Windows completo:

@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"
