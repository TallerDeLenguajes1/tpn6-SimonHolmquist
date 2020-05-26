# tpn6-SimonHolmquist
tpn6-SimonHolmquist created by GitHub Classroom

¿String es una tipo por valor o un tipo por referencia?

String es un tipo por referencia.

¿Qué secuencias de escape tiene el tipo string?

\ '- comilla simple (0x0027) <br>
\ "- comillas dobles (0x0022) <br>
\\ - barra invertida (0x005C) <br>
\ 0 - nulo (0x0000) <br>
\ a - alerta (0x0007) <br>
\ b - retroceso (0x0008) <br>
\ f - alimentación de formulario (0x000C) <br>
\ n - nueva línea (0x000A) <br>
\ r - retorno de carro (0x000D) <br>
\ t - pestaña horizontal (0x0009) <br>
\ v - pestaña vertical (0x000B) <br>
\ u0000 - \ uFFFF - Carácter Unicode <br>
\ x0 - \ xFFFF - Carácter Unicode (código con longitud variable) <br>
\ U00000000 - \ U0010FFFF - Carácter Unicode (para generar sustitutos) <br>

¿Qué sucede cuando utiliza el carácter @ antes de una cadena de texto?

En las cadenas textuales las secuencias de escape no se procesan, lo que facilita la escritura de, por ejemplo, un nombre de archivo Windows completo:

@"c:\Docs\Source\a.txt"  // rather than "c:\\Docs\\Source\\a.txt"
