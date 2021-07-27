'En este módulo están todos los queries usados en el proyecto
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
            "buscar_parametro", "SELECT c.Nombre, c.Apellido,c.ClienteId as 'Numero de Identidad', c.Extranjero, d.NombreDepartamento 
                                as Departamento, p.NombrePais as 'País', d.DepartamentoId as 'ID Departamento', p.IdPais as 'ID País'  FROM Clientes AS c 
                                INNER JOIN Departamentos as d on d.DepartamentoId = c.Procedencia 
                                INNER JOIN Paises as p on c.FkPaisId=p.IdPais
                                WHERE c.Nombre LIKE Concat('%', @Parametro, '%') 
                                OR c.Apellido LIKE Concat('%', @Parametro, '%')
                                OR c.Nombre + ' ' + c.Apellido LIKE Concat('%', @Parametro, '%')
                                OR c.ClienteId LIKE Concat('%', @Parametro, '%')
                                OR p.NombrePais LIKE Concat('%', @Parametro, '%')
                                OR d.NombreDepartamento LIKE Concat('%', @Parametro, '%')"
        }
    }

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
        }
    }

    'Diccionario con todos los queries relacionados a ventas
    Public queriesVentas As New Dictionary(Of String, String) From
     {
        {
            "insertar_venta", "INSERT INTO DetalleVenta(FkCodCliente, FkCodHabitacion, CostoHabitacion, FechaEntrada, 
                               Observacion, FkEmpleadoId)
                               VALUES(@FkCodCliente, @FkCodHabitacion, @CostoHabitacion, @FechaEntrada, @Observacion, 
                               @FkEmpleadoId)"
        },
        {
            "actualizar_venta", "UPDATE DetalleVenta SET FkCodCliente=@FkCodCliente,FkCodHabitacion=@FkCodHabitacion,CostoHabitacion=@CostoHabitacion,
                                FechaEntrada=@FechaEntrada,FechaSalida=@FechaSalida, Observacion=@Observacion,FkEmpleadoId=@FkEmpleadoId
                                WHERE DetalleVentaId=@DetalleVentaId"
        },
        {
            "obtener_ventas", "SELECT dv.DetalleVentaId, c.ClienteId, c.Nombre + ' ' + c.Apellido as Cliente,h.HabitacionId as 'Número de Habitación',
                               dv.CostoHabitacion, dv.FechaEntrada, dv.FechaSalida, dv.Observacion, e.Nombre as AtendidoPor  FROM DetalleVenta as dv 
                               INNER JOIN Clientes AS c on c.ClienteId = dv.FkCodCliente INNER JOIN Habitaciones as h on h.HabitacionId = dv.FkCodHabitacion 
                               INNER JOIN Empleados AS e on e.EmpleadoId = dv.FkEmpleadoId"
        },
        {
            "obtener_venta_cliente", "SELECT dv.DetalleVentaId, c.ClienteId, c.Nombre + ' ' + c.Apellido as Cliente,h.HabitacionId, h.NumHabitacion as NumeroHabitacion ,
                                      dv.CostoHabitacion, dv.FechaEntrada, dv.FechaSalida, dv.Observacion, e.Nombre as AtendidoPor  FROM DetalleVenta as dv 
                                      INNER JOIN Clientes AS c on c.ClienteId = dv.FkCodCliente 
                                      INNER JOIN Habitaciones as h on h.HabitacionId = dv.FkCodHabitacion 
                                      INNER JOIN Empleados AS e on e.EmpleadoId = dv.FkEmpleadoId where c.ClienteId=@ClienteId"
        },
        {
            "eliminar_venta", "DELETE FROM DetalleVenta WHERE DetalleVentaId=@DetalleVentaId"
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
            "actualizar_estado", "UPDATE Habitaciones SET EstadoDisponibilidad=@EstadoDisponibilidad 
                                  WHERE HabitacionId=@HabitacionId"
        },
        {
            "obtener_disponibles", "SELECT HabitacionId FROM Habitaciones WHERE EstadoDisponibilidad=1"
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
            "obtener_gastos", "SELECT ga.GastosAdicionalesId,ga.FkDetalleVenta as IdVenta, c.Nombre + ' ' + c.Apellido
                              as Cliente, p.ProductoId, p.NombreProducto as Producto,p.Precio, ga.Cantidad, ga.Total  
                              FROM GastosAdicionales AS ga 
                              INNER JOIN DetalleVenta AS dv on ga.FkDetalleVenta = dv.DetalleVentaId 
                              INNER JOIN Clientes as c on c.ClienteId = dv.FkCodCliente 
                              INNER JOIN Productos as p on p.ProductoId = ga.FkProductoId"
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

End Module
