'En este módulo están todos los queries usados en el proyecto.
Module mdl_Queries
    'Diccionario con todos los queries relacionados a clientes.
    Public queriesClientes As New Dictionary(Of String, String) From
    {
        {
            "insertar", "INSERT INTO [dbo].[Clientes]
                                ([ClienteId],[NombreCliente],[ApellidoCliente],[Extranjero],[FKDepartamentoId],[FkPaisId])
                                VALUES
                                (@ClienteId,@NombreCliente,@ApellidoCliente,@Extranjero,@FKDepartamentoId,@FkPaisId)"
        },
        {
            "actualizar", "UPDATE [dbo].[Clientes]
                                  SET [ClienteId] = @ClienteId,[NombreCliente] = @NombreCliente,[ApellidoCliente] = @ApellidoCliente,[Extranjero] = @Extranjero,[FKDepartamentoId] = @FKDepartamentoId,[FkPaisId] = @FkPaisId
                                  WHERE ClienteId=@ClienteId"
        },
        {
            "eliminar", "DELETE FROM [dbo].[Clientes]
                                WHERE ClienteId=@ClienteId"
        },
        {
            "obtener_todos", "SELECT 
                                   Clientes.NombreCliente AS Nombre, Clientes.ApellidoCliente AS Apellido,Clientes.ClienteId AS [Número de Identidad],Clientes.Extranjero, Departamentos.NombreDepartamento AS Departamento, Paises.NombrePais AS País, 
                                   Departamentos.DepartamentoId, Paises.PaisId
                              FROM Clientes INNER JOIN
                                   Departamentos ON Clientes.FKDepartamentoId = Departamentos.DepartamentoId INNER JOIN
                                   Paises ON Clientes.FkPaisId = Paises.PaisId"
        },
        {
            "obtener_por_parametro", "SELECT 
                                        Clientes.NombreCliente AS Nombre, Clientes.ApellidoCliente AS Apellido,Clientes.ClienteId AS [Número de Identidad],Clientes.Extranjero, Departamentos.NombreDepartamento AS Departamento, Paises.NombrePais AS País, 
                                        Departamentos.DepartamentoId, Paises.PaisId
                                     FROM Clientes INNER JOIN
                                        Departamentos ON Clientes.FKDepartamentoId = Departamentos.DepartamentoId INNER JOIN
                                        Paises ON Clientes.FkPaisId = Paises.PaisId
                                        WHERE Clientes.NombreCliente LIKE Concat('%', @Parametro, '%') 
                                        OR Clientes.ApellidoCliente LIKE Concat('%', @Parametro, '%')
                                        OR Clientes.NombreCliente + ' ' + Clientes.ApellidoCliente LIKE Concat('%', @Parametro, '%')
                                        OR Clientes.ClienteId LIKE Concat('%', @Parametro, '%')
                                        OR Paises.NombrePais LIKE Concat('%', @Parametro, '%')
                                        OR Departamentos.NombreDepartamento LIKE Concat('%', @Parametro, '%')"
        },
        {
            "buscar_id", "SELECT c.Nombre, c.Apellido,c.ClienteId as 'Numero de Identidad', c.Extranjero, d.NombreDepartamento 
                                as Departamento, p.NombrePais as 'País', d.DepartamentoId as 'ID Departamento', p.IdPais as 'ID País'  FROM Clientes AS c 
                                INNER JOIN Departamentos as d on d.DepartamentoId = c.Procedencia 
                                INNER JOIN Paises as p on c.FkPaisId=p.IdPais 
                                WHERE ClienteId=@ClienteId"
        },
        {
            "buscar_id_parametro", "SELECT c.Nombre, c.Apellido,c.ClienteId as 'Numero de Identidad', c.Extranjero, d.NombreDepartamento 
                                as Departamento, p.NombrePais as 'País', d.DepartamentoId as 'ID Departamento', p.IdPais as 'ID País'  FROM Clientes AS c 
                                INNER JOIN Departamentos as d on d.DepartamentoId = c.Procedencia 
                                INNER JOIN Paises as p on c.FkPaisId=p.IdPais 
                                WHERE ClienteId="
        },
        {
            "obtener_clientes", "SELECT c.Nombre, c.Apellido,c.ClienteId as 'Numero de Identidad', c.Extranjero, d.NombreDepartamento 
                                as Departamento, p.NombrePais as 'País', d.DepartamentoId as 'ID Departamento', p.IdPais as 'ID País'  FROM Clientes AS c 
                                INNER JOIN Departamentos as d on d.DepartamentoId = c.Procedencia 
                                INNER JOIN Paises as p on c.FkPaisId=p.IdPais"
        },
        {
            "actualizar_cliente", "UPDATE Clientes SET ClienteId=@ClienteId,Nombre=@Nombre,Apellido=@Apellido,Extranjero=@Extranjero,Procedencia=@Procedencia,
                                FkPaisId=@FkPaisId WHERE ClienteId=@ClienteId"
        },
        {
            "eliminar_cliente", "DELETE FROM Clientes where ClienteId=@ClienteId"
        },
        {
            "buscar_parametro", "SELECT c.NombreCliente AS [Nombre del cliente], c.ApellidoCliente as [Apellido del cliente],c.ClienteId as 'Numero de Identidad', c.Extranjero, d.NombreDepartamento 
                                as Departamento, p.NombrePais as 'País', d.DepartamentoId as 'ID Departamento', p.PaisId as 'ID País'  FROM Clientes AS c 
                                INNER JOIN Departamentos as d on d.DepartamentoId = c.FKDepartamentoId 
                                INNER JOIN Paises as p on c.FkPaisId=p.PaisId
                                WHERE c.NombreCliente LIKE Concat('%', @Parametro, '%') 
                                OR c.ApellidoCliente LIKE Concat('%', @Parametro, '%')
                                OR c.NombreCliente + ' ' + c.ApellidoCliente LIKE Concat('%', @Parametro, '%')
                                OR c.ClienteId LIKE Concat('%', @Parametro, '%')
                                OR p.NombrePais LIKE Concat('%', @Parametro, '%')
                                OR d.NombreDepartamento LIKE Concat('%', @Parametro, '%')"
        }
    }
    'Diccionario con todos los queries relacionados a servicios
    Public queriesServicios As New Dictionary(Of String, String) From {
        {
            "insertar", "INSERT INTO [dbo].[Servicios]
                            ([Descripcion], [Precio] ,[EstadoServicio])
                    VALUES
                            (@Descripcion, @Precio, @EstadoServicio)"
        },
        {
            "actualizar", "UPDATE [dbo].[Servicios]
                           SET Descripcion = @Descripcion,
                               Precio = @Precio,
                               EstadoServicio = @EstadoServicio
                         WHERE ServicioId=@ServicioId"
        },
        {
            "obtener", "SELECT  ServicioId AS ID, Descripcion, Precio, EstadoServicio AS [Estado del Servicio]
                        FROM    Servicios"
        },
        {
            "eliminar", "DELETE *FROM Servicios WHERE ServicioId=@ServicioId"
        },
        {
            "obtener_disponibles", "SELECT ServicioId, Descripcion AS [Descripción del servicio], Precio AS [Precio del servicio]
                                    FROM  Servicios WHERE EstadoServicio=1"
        }
    }


    'Diccionario con todos los queries relacionados a ventas
    Public queriesVentas As New Dictionary(Of String, String) From
     {
        {
            "obtener", "SELECT Ventas.VentaId, Ventas.FechaEntrada AS [Fecha de entrada],Ventas.DiasEstadia as [Dias de estadía], Ventas.TotalVenta AS [Total de la venta], Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente], 
                               Clientes.ClienteId AS [Identidad del cliente]
                       FROM    Ventas INNER JOIN
                               Clientes ON Ventas.FkClienteId = Clientes.ClienteId"
        },
        {
            "obtener_id", "SELECT Ventas.FechaEntrada AS [Fecha de entrada],Ventas.FechaSalida AS [Fecha de salida],Ventas.DiasEstadia AS [Dias de estadía], Ventas.TotalVenta AS [Total de la venta], Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente], 
                               Clientes.ClienteId AS [Identidad del cliente]
                       FROM    Ventas INNER JOIN
                               Clientes ON Ventas.FkClienteId = Clientes.ClienteId
                               WHERE Ventas.VentaId=@VentaId"
        },
        {
            "insertar", "INSERT INTO [dbo].[Ventas]
                                            ([FechaEntrada],[DiasEstadia],[TotalVenta],[FkClienteId],[FkEmpleadoId])
                               VALUES (@FechaEntrada,@DiasEstadia,@TotalVenta,@FKClienteId,@FKEmpleadoId)"
        },
        {
            "obtener_ultima_venta", "SELECT IDENT_CURRENT('Ventas') AS VentaId"
        },
        {
            "insertar_habitaciones", "INSERT INTO [dbo].[DetalleHabitaciones]
                                            ([HabitacionId],[VentaId])
                                    VALUES
                                            (@HabitacionId,@VentaId)"
        },
        {
            "insertar_servicios", "INSERT INTO [dbo].[DetalleServicios]
                                          ([ServicioId],[VentaId])
                                   VALUES
                                          (@ServicioId, @VentaId)"
        },
        {
            "obtener_servicios", "SELECT Servicios.Descripcion AS [Descripción del servicio], Servicios.Precio as [Costo del servicio]
                                  FROM   Ventas INNER JOIN
                                         DetalleServicios ON Ventas.VentaId = DetalleServicios.VentaId INNER JOIN
                                         Servicios ON DetalleServicios.ServicioId = Servicios.ServicioId
                                  WHERE  (Ventas.VentaId = @VentaId)"
        },
        {
            "obtener_habitaciones", "SELECT Habitaciones.HabitacionId as [Número de habitación], Habitaciones.CostoHabitacion as [Costo de la habitación]
                                     FROM   Ventas INNER JOIN
                                            DetalleHabitaciones ON Ventas.VentaId = DetalleHabitaciones.VentaId INNER JOIN
                                            Habitaciones ON DetalleHabitaciones.HabitacionId = Habitaciones.HabitacionId
                                     WHERE (Ventas.VentaId = @VentaId)"
        },
        {
            "actualizar_salida", "UPDATE DetalleVenta SET FechaSalida=@FechaSalida WHERE DetalleVentaId=@DetalleVentaId"
        },
        {
            "actualizar_gasto", "UPDATE DetalleVenta SET GastoAdicional=@GastoAdicional WHERE DetalleVentaId=@DetalleVentaId"
        },
        {
            "obtener_ventas_anio", "SELECT dv.DetalleVentaId, c.ClienteId, c.Nombre + ' ' + c.Apellido as Cliente,h.HabitacionId as 'Número de Habitación',
                                   dv.CostoHabitacion, dv.FechaEntrada, dv.FechaSalida, dv.Observacion, e.Nombre as AtendidoPor  FROM DetalleVenta as dv 
                                   INNER JOIN Clientes AS c on c.ClienteId = dv.FkCodCliente INNER JOIN Habitaciones as h on h.HabitacionId = dv.FkCodHabitacion 
                                   INNER JOIN Empleados AS e on e.EmpleadoId = dv.FkEmpleadoId
                                   WHERE YEAR(dv.FechaEntrada)=@Anio"
        },
        {
            "obtener_ventas_mes", "SELECT dv.DetalleVentaId, c.ClienteId, c.Nombre + ' ' + c.Apellido as Cliente,h.HabitacionId as 'Número de Habitación',
                                   dv.CostoHabitacion, dv.FechaEntrada, dv.FechaSalida, dv.Observacion, e.Nombre as AtendidoPor  FROM DetalleVenta as dv 
                                   INNER JOIN Clientes AS c on c.ClienteId = dv.FkCodCliente INNER JOIN Habitaciones as h on h.HabitacionId = dv.FkCodHabitacion 
                                   INNER JOIN Empleados AS e on e.EmpleadoId = dv.FkEmpleadoId
                                   WHERE YEAR(dv.FechaEntrada)=@Anio AND MONTH(dv.FechaEntrada)=@Mes"
        },
         {
            "obtener_ventas_dia", "SELECT dv.DetalleVentaId, c.ClienteId, c.Nombre + ' ' + c.Apellido as Cliente,h.HabitacionId as 'Número de Habitación',
                                   dv.CostoHabitacion, dv.FechaEntrada, dv.FechaSalida, dv.Observacion, e.Nombre as AtendidoPor  FROM DetalleVenta as dv 
                                   INNER JOIN Clientes AS c on c.ClienteId = dv.FkCodCliente INNER JOIN Habitaciones as h on h.HabitacionId = dv.FkCodHabitacion 
                                   INNER JOIN Empleados AS e on e.EmpleadoId = dv.FkEmpleadoId
                                   WHERE dv.FechaEntrada=@FechaEntrada"
        }
    }

    'Diccionario con todos lo queries relacionados a las habitaciones
    Public queriesHabitaciones As New Dictionary(Of String, String) From
    {
        {
            "obtener_disponibles", "SELECT Habitaciones.HabitacionId AS [Número de Habitación], Habitaciones.CostoHabitacion AS [Costo de la Habitación], TipoHabitaciones.Descripcion AS [Tipo de Habitación], Habitaciones.CantCamas AS [Cant. de Camas], 
                                           TipoCamas.Descripcion AS [Tipo de Cama], Habitaciones.CantAlmohadas AS [Cant. de Almohadas], Habitaciones.CantMesas AS [Cant. de Mesas], Habitaciones.CantSillas AS [Cant. de Sillas], 
                                           TipoAiresAcondicionados.DescripcionAire AS [Tipo de Aire]
                                    FROM   Habitaciones INNER JOIN
                                           TipoAiresAcondicionados ON Habitaciones.FKTipoAireId = TipoAiresAcondicionados.TipoAireId INNER JOIN
                                           TipoCamas ON Habitaciones.FKTipoCamaId = TipoCamas.TipoCamaId INNER JOIN
                                           TipoHabitaciones ON Habitaciones.FKTipoHabitacionId = TipoHabitaciones.TipoHabitacionId
                                           WHERE Habitaciones.EstadoDisponibilidad=1"
        },
        {
            "actualizar_estado", "UPDATE Habitaciones SET EstadoDisponibilidad=0 
                                  WHERE HabitacionId=@HabitacionId"
        },
        {
            "actualizar_estado2", "UPDATE Habitaciones SET EstadoDisponibilidad=1 
                                  WHERE HabitacionId=@HabitacionId"
        }
    }

    'Diccionario con todos los queries relacionados a gastos adicionales
    Public queriesGastos As New Dictionary(Of String, String) From
    {
        {
            "obtener_gasto", "SELECT ga.GastosAdicionalesId,ga.FkDetalleVenta as IdVenta, c.Nombre + ' ' + c.Apellido
                              as Cliente, p.ProductoId, p.NombreProducto as Producto,p.Precio, ga.Cantidad, ga.Total  
                              FROM GastosAdicionales AS ga 
                              INNER JOIN DetalleVenta AS dv on ga.FkDetalleVenta = dv.DetalleVentaId 
                              INNER JOIN Clientes as c on c.ClienteId = dv.FkCodCliente 
                              INNER JOIN Productos as p on p.ProductoId = ga.FkProductoId
                              WHERE c.ClienteId="
        },
        {
            "insertar_gasto", "INSERT INTO GastosAdicionales(FkDetalleVenta, FkProductoId, Cantidad, Total) 
                               VALUES(@FkDetalleVenta, @FkProductoId, @Cantidad, @Total)"
        },
        {
            "obtener_gastos", "SELECT Clientes.NombreCliente + ' ' +Clientes.ApellidoCliente as [Cliente], Clientes.ClienteId AS [Número de Identidad], Productos.NombreProducto AS Producto, Productos.Precio, GastosAdicionales.Cantidad, 
                                      GastosAdicionales.TotalGasto AS Total
                               FROM   GastosAdicionales INNER JOIN
                                      Productos ON GastosAdicionales.FkProductoId = Productos.ProductoId INNER JOIN
                                      Ventas ON GastosAdicionales.FkVentaId = Ventas.VentaId INNER JOIN
                                      Clientes ON Ventas.FkClienteId = Clientes.ClienteId"
        },
        {
            "actualizar_gastos", "update GastosAdicionales set FkDetalleVenta=@FkDetalleVenta,FkProductoId=@FkProductoId,Cantidad=@Cantidad,Total=@Total 
                                  where GastosAdicionalesId=@GastosAdicionalesId"
        },
        {
            "eliminar_gasto", "delete from GastosAdicionales where GastosAdicionalesId=@GastosAdicionalesId"
        }
    }

    'Diccionario con todos los queries relacionados a empleados
    Public queriesEmpleados As New Dictionary(Of String, String) From
    {
        {
            "obtener_recepcionistas", "SELECT *FROM Empleados WHERE Cargo='Recepcionista'"
        }
    }

    'Diccionario con todos los queries relacionados a países
    Public queriesPaises As New Dictionary(Of String, String) From
    {
        {
            "obtener", "SELECT Paises.PaisId, Paises.NombrePais as [Nombre del país] FROM Paises"
        },
        {
            "obtener_nombre", "SELECT Paises.PaisId, Paises.NombrePais as [Nombre del país] FROM Paises
                               WHERE Paises.NombrePais LIKE '%@NombrePais%'"
        }
    }

    'Diccionario con todos los queries relacionados a departamentos
    Public queriesDeptos As New Dictionary(Of String, String) From
    {
        {
            "obtener", "SELECT Departamentos.DepartamentoId, Departamentos.NombreDepartamento as [Nombre del departamento] FROM Departamentos
                        WHERE NOT NombreDepartamento = 'NA'"
        },
        {
            "obtener_nombre", "SELECT Paises.PaisId, Paises.NombrePais as [Nombre del país] FROM Paises
                               WHERE Paises.NombrePais LIKE '%@NombrePais%'"
        }
    }

    'Diccionario con todos los queries relacionados a países
    Public queriesProductos As New Dictionary(Of String, String) From
    {
        {
            "obtener_activos", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio
                                FROM Productos
                                WHERE Productos.EstadoProducto=1"
        },
        {
            "obtener_todos", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio, Productos.EstadoProducto as [Estado del producto]
                              FROM Productos"
        },
        {
            "obtener_producto", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio, Productos.EstadoProducto as [Estado del producto]
                                FROM Productos
                                WHERE Productos.NombreProducto LIKE CONCAT('%', @NombreProducto, '%')"
        },
        {
            "obtener_producto_activo", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio
                                FROM Productos
                                WHERE Productos.EstadoProducto=1 AND Productos.NombreProducto LIKE CONCAT('%', @NombreProducto, '%')"
        },
        {
            "obtener_nombre", "SELECT Paises.PaisId, Paises.NombrePais as [Nombre del país] FROM Paises
                               WHERE Paises.NombrePais LIKE '%@NombrePais%'"
        },
        {
            "insertar", "INSERT INTO [dbo].[Productos] ([NombreProducto],[Precio],[EstadoProducto])
                         VALUES (@NombreProducto,@Precio,@EstadoProducto)"
        },
        {
            "actualizar", "UPDATE [dbo].[Productos]
                           SET [NombreProducto]=@NombreProducto,[Precio]=@Precio,[EstadoProducto]=@EstadoProducto
                           WHERE ProductoId=@ProductoId"
        }
    }

End Module
