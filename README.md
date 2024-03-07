# Calculadora3D

## forms

### ingresar
la app tiene un sistema de ingreso para que al consultar se tenga en cuenta el consumo de la maquina que se utiliza.
tambien permite crear nuevos usuarios

![ingresa 6_3_2024 18_07_16](https://github.com/bautista-escalante/Calculadora3D/assets/123372673/982eb31b-d8bc-4cb5-a83a-c5089901e717)

### registrarse
en el formulario de creacion de usuario, una vez completado todos los campos el usuario debe realizar un captcha para crear su perfil

![Registrate 6_3_2024 18_07_48](https://github.com/bautista-escalante/Calculadora3D/assets/123372673/de49b09f-b29b-4908-b228-1917c624a14c)

### principal

los datos como el tiempo y los gramos de filamento necesarios son obtenidos desde cura (software para impresion 3D).

una vez ingresado se calcula el valor de la pieza y se muestra en pantalla

![Principal 6_3_2024 18_09_36](https://github.com/bautista-escalante/Calculadora3D/assets/123372673/8567dd00-806f-4273-93ad-ce37240df23a)

### exeptions

en ingresar hay dos exepciones 
* **IngresoIncorrectoExeption**
  
  se activa cuando el usuario ingresa mal el nombre o la contraseña
  
![exeption contraseña](https://github.com/bautista-escalante/Calculadora3D/assets/123372673/d631df8d-f17b-4c33-8753-2e020b793f20)

* **CuentaExistenteExeption**

  se activa cuando la cuenta no existe

  ![ingresa 6_3_2024 20_02_36](https://github.com/bautista-escalante/Calculadora3D/assets/123372673/d294eb37-1b85-4b1e-a50c-f6f48563d5cc)

en  registrarse hay cuatro exepciones

* **CuentaExistenteExeption**

  en este caso se aplica cuando el usuario que intenta crear ya existe

*  **ContraseñaDistintaExeption**

  se activa cuando las contraseñas no son iguales

*  **CampoVacioexeption**



*  **comboBoxInexistenteExeption**

se activa cuando se ingresa una opcion no disponible dentro de las opciones den comboBox

* **CaptchaNoCompletadoExeption**

  







