# Primer Parcial de Laboratorio de Computacion 2

# Nombre de la App: Bazinga Airlines
## Alumno: Maggiori, Gianni


### Sobre mi:

Mi nombre es Gianni, Maggiori. Tengo 30 años actualmente cursando la tecnicatura universitaria en programación y sistemas en la Universidad Tecnológica Nacional.
Mi experiencia programando es de aproximadamente 1 año. El parcial represento un desafío muy interesante, por su nivel de dificultad. Aprendí muchísimo creando este proyecto, por momentos frustrante y por momentos ligero pero siempre entretenido.

## Resumen de la aplicación:

La aplicacion simula un sistema de atención a clientes de una aerolinea, contiene un ABM (alta, baja y modificación) de clientes registrados en la aplicación, una sección de venta de pasajes para los distintos vuelos que ofrece, y una seccion de informes donde se puede visualizar informes variados como estados de vuelos, estadisticas historicas, información de clientes etc.

## La Aplicación:

Cuenta con un login donde uno puede introducir su nombre de usuario y su contraseña para loguearse al sistema, si no tenes usuario se puede crear desde el boton "Nuevo Usuario", el cual abrira una nueva ventana donde podras crear un nuevo usuario y loguearte con ese, o se puede elegir ingresar con el usuario de testeo predeterminado desde el boton "Test" y luego en "Iniciar Sesion", para cerrar la aplicacion se debe utilizar el boton "Salir".

![image](https://user-images.githubusercontent.com/86836893/193817401-77843df1-be03-4d6d-807a-ffc32c5224f8.png)


Una vez logueado se muestra la pantalla principal del programa.


![image](https://user-images.githubusercontent.com/86836893/193821988-b9b8a31d-9e07-4a69-a786-c30f5640ef05.png)


Esta es la pantalla principal del programa, desde aqui se accede a los distintos sectores: Informacion y Modificaciones, Pasajes, Configuracion o Salir.

## Informacion y Modificaciones:


### Vuelos:


En esta seccion se muestran los vuelos de 3 formas distintas, por defecto muestra el historial completo de vuelos, pero tambien permite filtrar por vuelos pasados o los vuelos que estan programados a futuro.


![image](https://user-images.githubusercontent.com/86836893/193824009-23d820c5-12ef-4cf5-b444-3bce24fcb481.png)


Al hace click en algunas de las filas se abrira una segunda pantalla donde se muestra la lista de pasajeros del vuelo que se selecciono, y al hacerle click a alguno de los pasajeros de ese vuelo se mostraran datos especificos de ese pasajero.


![image](https://user-images.githubusercontent.com/86836893/193825088-3f1ef9f3-1c9e-424e-8bfd-c2a4b61480de.png)


Para cerrar esa ventana hay que hacer click en el boton "Volver".


### Aviones:


Al entrar aqui se muestra una lista con todos los aviones que forman parte de la flota de la aerolinea.


![image](https://user-images.githubusercontent.com/86836893/193825989-b5e19616-7d32-4609-9044-3cc4641c5f03.png)


Si se quiere agregar un avion nuevo hay que hacer click donde dice "Agregar Avion" el cual abrira una ventana nueva donde se le dara de alta a un nuevo avion.


![image](https://user-images.githubusercontent.com/86836893/193826237-31db64f0-80f4-41cf-a1ac-2748678c26ce.png)


El avion se sumara a la lista cuando se haga click en "Comprar Avion" o se puede cancelar el alta haciendo click en "Cancelar Compra".


### Cliente:


![image](https://user-images.githubusercontent.com/86836893/193826918-24dae09f-55e3-4424-878a-d330f344b336.png)


En esta seccion se muestran todos los datos de los clientes registrados en la app, desde aqui se puede dar de alta un cliente haciendo click en "Añadir Cliente", el cual abrira una ventana nueva donde se dara de alta al nuevo cliente con sus datos, tambien se pueden modificar datos de un cliente existente haciendo click en el boton "Modificar Cliente" de la misma forma que cuando damos de alta, o se podra eliminar un cliente haciendo click en "Eliminar Cliente", este ultimo boton elimina al cliente de forma directa, tener cuidado con eso. 
En el cuadro de busqueda se puede filtrar por DNI la lista de clientes, y el boton limpiar limpia el cuadro de texto para realizar otra busqueda.


![image](https://user-images.githubusercontent.com/86836893/193827834-1a94c363-7c04-46c9-bdff-522754ef459a.png)


![image](https://user-images.githubusercontent.com/86836893/193827920-64754cd3-95fe-46d6-81fc-7d768eae6c9d.png)


![image](https://user-images.githubusercontent.com/86836893/193828036-4a48bb43-0911-4477-a0af-1037aecde98a.png)


### Facturacion:


Aqui se muestran los datos de facturacion, seleccionando el tipo de facturacion que deseamos consultar (puede ser la recaudacion total, solo de los viajes internacionales o solo nacionales).


![image](https://user-images.githubusercontent.com/86836893/193828622-4670e2ec-7269-4ea0-8243-4ca5165e6158.png)


Para salir de esa ventana hay que hacer click en "Cerrar".


## Pasajes:


Aqui es donde se venden los pasajes a los clientes de la aerolinea.


### Vender:


Primero se vera la pantalla por defecto.


![image](https://user-images.githubusercontent.com/86836893/193829727-0c1bc890-4266-48bd-8a30-d6cc4f34bd0c.png)


Lo primero que haremos aqui, es seleccionar el origen de un vuelo y luego el destino, luego la categoria que desea el cliente (esto es si quiere viajar en clase comercial o clase ejecutiva) y finalmente la cantidad de tickets que quiere comprar el cliente.
Luego le damos click al boton "Buscar Vuelo", esto lo que va a hacer es traer todos los vuelos que tienen ese recorrido. Luego de hacer click en "Buscar Vuelo" se va a mostrar una lista de vuelos.


![image](https://user-images.githubusercontent.com/86836893/193831024-8f898b45-e633-4832-8549-9d6c653a7ed6.png)


Al hacer click en algunos de los vuelos, se abrira una nueva ventana.


![image](https://user-images.githubusercontent.com/86836893/193831365-30b36763-7e78-4087-bdac-ea01bd14d3f0.png)


En esta nueva ventana, se deberan elegir el o los clientes que desean reservar un voleto de avion en el vuelo elegido previamente. Para eso haremos click en "Seleccionar Cliente" lo cual abrira el formulario de informe de clientes (ya mostrado en el apartado de informes de clientes) pero ahora habra habilitado un nuevo boton llamado "Seleccionar".


![image](https://user-images.githubusercontent.com/86836893/193832245-c4e4ffe3-f81d-4fd7-8162-d166b2c4c1e2.png)


Aqui se seleccionara a el o los clientes que van a comprar un boleto de avion simplemente seleccionando individualmente al cliente y haciendo click en "Seleccionar", este proceso se debera repetir tantas veces sean necesarias hasta haber seleccionado la misma cantidad de clientes como cantidad de tickets haya pedido comprar en la seccion de busqueda de vuelos, una vez terminado eso, se volvera a la ventana anterior pero ahora se visualizara a el o los clientes seleccionados.


![image](https://user-images.githubusercontent.com/86836893/193834422-6eb22e79-a5d9-4d31-8acd-b0cfa58bc4dd.png)


Una vez hecho eso, lo siguiente es completar los datos requeridos del vuelo con las preferencias del cliente con respecto al vuelo.


![image](https://user-images.githubusercontent.com/86836893/193834795-7165d4a0-774e-4d41-b222-ed9491ed73b2.png)


Una vez confirmados los datos de preferencia del cliente con respecto al vuelo que va a comprar, haremos click en "Confirmar Pasajero". Esto hara que el cliente desaparezca de la lista mostrada arriba, y se muestre abajo. Esto nos indica que el pasajero esta confirmado correctamente.


![image](https://user-images.githubusercontent.com/86836893/193836305-1790edf8-70a7-4f68-90f1-86ddc42a776a.png)


Tambien podemos visualizar los datos de la facturacion del ticket que acabamos de confirmar la venta en el cuadro de texto que esta al lado de los botones.


![image](https://user-images.githubusercontent.com/86836893/193836585-b0d97a0e-c436-46ce-a219-70d2a71a00d4.png)


## Configuracion:


En esta seccion vamos a encontrar 2 apartados.


### Modificar Usuario: 


Al hacer click en esta seccion se abrira una ventana donde nos permitira modificar ciertos datos del usuario tales como el nombre de usuario, la contraseña, el telefono.


![image](https://user-images.githubusercontent.com/86836893/193843030-5feecf7c-e8ee-4c67-b866-acf12b119c36.png)


Para confirmar la modificacion de datos debemos hacer click en el boton "Confirmar", esto modificara los datos del usuario que esta logueado actualmente, y actualizara la pantalla principal para mostrar el nombre del usuario logueado correctamente. Como se muestra en la siguiente imagen.


![image](https://user-images.githubusercontent.com/86836893/193851015-f683ba84-a6f7-4f4f-996d-2e828e1908c4.png)


![image](https://user-images.githubusercontent.com/86836893/193851401-ca00578e-b666-4e66-bd93-3907c0a084ce.png)


![image](https://user-images.githubusercontent.com/86836893/193851578-8532143e-b332-4503-ba9c-c617cc289925.png)


### Cerrar Sesion:


Este boton cerrara la sesion actual del usuario que este logueado pero manteniendo los datos anteriores.


## Salir:


Este boton tiene una funcionalidad en cascada, esto quiere decir que antes de cerrar la aplicacion, se deben cerrar los formularios que estan contenidos dentro de la pantalla principal y finalmente cuando esten todos cerrados, va a ser posible cerrar la aplicacion.
