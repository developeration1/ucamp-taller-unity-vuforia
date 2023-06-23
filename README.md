# Demo Unity + Vuforia 2023
Este repositorio tiene la finalidad de demostrar el uso de Vuforia en el motor de videojuegos de Unity.

## Errores conocidos
Puede que sea necesario reinstalar algunos paquetes a traves del Package Manager, como lo es Text Mesh Pro.
Igualmente reinstalar Vuforia.
Se procura arreglar más adelante.

## Instrucciones de uso
1. Instalar Unity Hub y Unity 2022.3.2 junto a Visual Studio 2022
2. Desacargar repositorio.
3. Abrir proyecto con apoyo de Unity Hub.
4. Crear una cuenta de usuario de Vuforia o iniciar sesión en https://developer.vuforia.com/vui/auth/login
5. En el dashboard, ir al administrador de licencias.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/1c847d62-618b-496f-b108-30041d82e34b)
6. Crear una licencia básica.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/d7e4e50a-18bc-444e-bccd-13f72d3f4078)
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/b3fa5b06-83e2-4bd3-81e8-2c4bba556501)
7. En el administrador de licencias, hacer click en la recién creada.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/358f0645-eeae-41f7-8863-1f4cff17dae4)
8. Copiar la licencia.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/c2e5d6fd-8e58-4416-b96c-4145053b8e2d)
9. En nuestro proyecto de Unity, ir a la carpeta Resources de nuestros Assets, hacer click sobre el archivo VuforiaConfiguration, y aquí pegar la licencia en el espacio "App Licence Key"
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/7d3b1390-eafa-4bfc-8758-ba9541b19476)
10. Ir al Target Manager y crear una nueva base de datos.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/88cedc06-7844-4146-a430-96c1d04f5eec)
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/ec7516d8-62c9-4d26-97cb-79ea27ee4143)
11. Hacer click sobre la base de datos recién creada y crear un nuevo target.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/287e7ff6-2e73-4a4f-a1ad-a43ff3612b9b)
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/1a310131-2e03-47ca-b601-f878c72b5270)
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/da1a9f91-a891-4fb0-b0a3-de0e64fb1dd0)
12. Recargar la página para ver el resultado del rating (para que sea una buena imágen para target AR, es recomendable que cumpla con 5 estrellas.
![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/3faeaf43-7376-43c6-9bdf-557b47d7ac9b)
Para más información respecto al cómo se calcula el rating, visita: https://library.vuforia.com/objects/best-practices-designing-and-developing-image-based-targets.

Se recomienda usar esta imagen:
![taller-space-15](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/46c02f07-a2d1-47de-b0d4-b45733dd4b23)

13. Descargar base de datos, y hacer doble click sobre el .unitypackage descargado para poder instalar en el proyecto (se requiere tener el proyecto abierto, preferiblemente no más de un proyecto para evitar conflictos).

![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/d093d046-52dc-4e2f-83d7-6dfa2bcf2514)

![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/6620f2ee-23df-47c2-8a8c-029ac8fc6d73)

![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/fcc6d142-3e80-482a-aefe-8e594141149c)

![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/a34f5bc6-7516-4b8e-8ceb-a2b71ee66d55)

14. En el Image Target en la escena "Game", seleccionar la base de datos y seleccionar el target.

![image](https://github.com/developeration1/ucamp-taller-unity-vuforia/assets/42705200/dba5aa1b-e39c-43dd-bd35-41c04a9324db)

Con eso el proyecto se puede probar; Tómate el tiempo de analizar el proyecto, investigarlo, modificarlo, hacer una escena nueva incluso; Recuerda ¡nunca dejes de crear y diviertete haciendolo!

Atte. Adrián Rangel Suárez, The Developer
