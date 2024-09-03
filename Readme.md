1. primero creamos la carpeta Models y sus clases con sus data anotations, en ellas creamos su relacion como se especifica en la clase vehiculo
2. Creamos la carpeta Data y el db context 
3. creamos el .env que son las credenciales de la base de datos 
4. en program.cs cargamos el env con sus variables y creamos la conexion a la base de datos
5. Hacemos la migracion a la base de datos de la siguiente manera:
    - las migraciones nos sirven para llevar una trazabilidad de la base de datos ya que nos dejan un registro de lo que se modifica en la base de datos
    # Para las migraciones, dotnet ef add migrations nombre de la migracion
    - pero en este momento la migracion no ha sido efectiva, se puede decir que esta en un stagging hasta que se guarde la migracion

    # Para guardar la migracion: dotnet ef database update
    - Con este comando se envia la migracion a la base de datos
