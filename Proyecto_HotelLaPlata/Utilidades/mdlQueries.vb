'-----------------------------------------------------------------------------------------------------------------
'   Módulo: Utilidades
'   Clase: mdlQueries
'   Función: almacenar todos los queries para hacer consultas e inserciones
'-----------------------------------------------------------------------------------------------------------------

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
            "obtener", "SELECT  ServicioId, Descripcion as [Descripción del servicio], Precio as [Precio del servicio(L)], EstadoServicio AS [Estado del Servicio]
                        FROM    Servicios"
        },
        {
            "eliminar", "DELETE *FROM Servicios WHERE ServicioId=@ServicioId"
        },
        {
            "obtener_disponibles", "SELECT ServicioId, Descripcion AS [Descripción del servicio], Precio AS [Precio del servicio (L)]
                                    FROM  Servicios WHERE EstadoServicio=1"
        }
    }


    'Diccionario con todos los queries relacionados a ventas
    Public queriesVentas As New Dictionary(Of String, String) From
     {
        {
            "obtener", "SELECT Ventas.VentaId, Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente],Clientes.ClienteId AS [Identidad del cliente],Ventas.DiasEstadia as [Dias de estadía], Ventas.TotalVenta AS [Total de la venta(L)], Ventas.FechaEntrada AS [Fecha de entrada]   
                        FROM    Ventas INNER JOIN
                               Clientes ON Ventas.FkClienteId = Clientes.ClienteId
                               ORDER BY Ventas.VentaId DESC"
        },
        {
            "obtener_por_cliente", "SELECT Ventas.VentaId, Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente],Clientes.ClienteId AS [Identidad del cliente],Ventas.DiasEstadia as [Dias de estadía], Ventas.TotalVenta AS [Total de la venta(L)], Ventas.FechaEntrada AS [Fecha de entrada]   
                        FROM    Ventas INNER JOIN
                               Clientes ON Ventas.FkClienteId = Clientes.ClienteId
                               WHERE Clientes.NombreCliente LIKE Concat('%', @Parametro, '%')
                               OR Clientes.ApellidoCliente LIKE Concat('%', @Parametro, '%')
                               OR Clientes.NombreCliente + ' ' + ApellidoCliente LIKE Concat('%', @Parametro, '%')
                               OR Clientes.ClienteId LIKE Concat('%', @Parametro, '%')
                               ORDER BY Ventas.VentaId DESC"
        },
        {
            "obtener_ventas_salida", "SELECT Ventas.VentaId, Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente],Clientes.ClienteId AS [Identidad del cliente],Ventas.DiasEstadia as [Dias de estadía], Ventas.TotalVenta AS [Total de la venta(L)], Ventas.FechaEntrada AS [Fecha de entrada]   
                                      FROM    Ventas INNER JOIN
                                              Clientes ON Ventas.FkClienteId = Clientes.ClienteId
                                              WHERE Ventas.EstadoVenta=1
                                              ORDER BY Ventas.VentaId DESC"
        },
        {
            "obtener_id", "SELECT Ventas.FechaEntrada AS [Fecha de entrada],Ventas.FechaSalida AS [Fecha de salida],Ventas.DiasEstadia AS [Dias de estadía], Ventas.TotalVenta AS [Total de la venta(L)], Clientes.NombreCliente AS [Nombre del cliente], Clientes.ApellidoCliente AS [Apellido del cliente], 
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
            "obtener_servicios", "SELECT Servicios.Descripcion AS [Descripción del servicio], Servicios.Precio as [Costo del servicio(L)]
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
            "actualizar_salida", "UPDATE Ventas SET FechaSalida=@FechaSalida, EstadoVenta=0 WHERE Ventas.VentaId=@VentaId"
        },
        {
            "obtener_ventas_anio", "SELECT Year(FechaEntrada) as [Año],
		                            DATENAME(month,FechaEntrada) as Mes,
		                            Sum(TotalVenta) as TotalVenta
		                            FROM Ventas
		                            Where Year(FechaEntrada) = Year(@Parametro)
		                            Group by Year(FechaEntrada),DATENAME(month,FechaEntrada)
		                            Order by year(FechaEntrada),DATENAME(month,FechaEntrada)"
        }
    }

    'Diccionario con todos lo queries relacionados a las habitaciones
    Public queriesHabitaciones As New Dictionary(Of String, String) From
    {
        {
            "obtener_disponibles", "SELECT Habitaciones.HabitacionId AS [Número de Habitación], Habitaciones.CostoHabitacion AS [Costo de la Habitación(L)], TipoHabitaciones.Descripcion AS [Tipo de Habitación], Habitaciones.CantCamas AS [Cant. de Camas], 
                                           TipoCamas.Descripcion AS [Tipo de Cama], Habitaciones.CantAlmohadas AS [Cant. de Almohadas], Habitaciones.CantMesas AS [Cant. de Mesas], Habitaciones.CantSillas AS [Cant. de Sillas], 
                                           TipoAiresAcondicionados.DescripcionAire AS [Tipo de Aire]
                                    FROM   Habitaciones INNER JOIN
                                           TipoAiresAcondicionados ON Habitaciones.FKTipoAireId = TipoAiresAcondicionados.TipoAireId INNER JOIN
                                           TipoCamas ON Habitaciones.FKTipoCamaId = TipoCamas.TipoCamaId INNER JOIN
                                           TipoHabitaciones ON Habitaciones.FKTipoHabitacionId = TipoHabitaciones.TipoHabitacionId
                                           WHERE Habitaciones.EstadoDisponibilidad=1"
        },
        {
            "obtener", "SELECT Habitaciones.HabitacionId AS [Número de habitación], Habitaciones.CostoHabitacion AS [Costo(L)], Habitaciones.CantCamas AS [Cant. Camas], Habitaciones.CantAlmohadas AS [Cant. Almohadas], 
                               Habitaciones.CantMesas AS [Cant. Mesas], Habitaciones.CantSillas AS [Cant. Sillas], Habitaciones.CantTVs AS [Cant. TV's'],  
                               TipoCamas.Descripcion AS [Tipo de cama], TipoAiresAcondicionados.DescripcionAire AS [Tipo de aire], TipoHabitaciones.Descripcion AS [Tipo de habitación],Habitaciones.Observacion AS [Observación], TipoCamas.TipoCamaId, TipoHabitaciones.TipoHabitacionId, 
                               TipoAiresAcondicionados.TipoAireId
                        FROM   TipoHabitaciones INNER JOIN
                               Habitaciones ON TipoHabitaciones.TipoHabitacionId = Habitaciones.FKTipoHabitacionId INNER JOIN
                               TipoCamas ON Habitaciones.FKTipoCamaId = TipoCamas.TipoCamaId INNER JOIN
                               TipoAiresAcondicionados ON Habitaciones.FKTipoAireId = TipoAiresAcondicionados.TipoAireId"
        },
         {
            "obtener_venta", "    UPDATE Habitaciones SET EstadoDisponibilidad=0 
                                  WHERE HabitacionId=@HabitacionId"
        },
        {
            "actualizar_estado", "UPDATE Habitaciones SET EstadoDisponibilidad=0 
                                  WHERE HabitacionId=@HabitacionId"
        },
        {
            "actualizar_estado2", "UPDATE Habitaciones SET EstadoDisponibilidad=1 
                                  WHERE HabitacionId=@HabitacionId"
        },
        {
            "insertar", "INSERT INTO [dbo].[Habitaciones]([HabitacionId],[CostoHabitacion],[CantCamas],[CantAlmohadas],[CantMesas],
			                               [CantSillas],[Observacion],[CantTVs],[FKTipoAireId],[FKTipoHabitacionId],[FKTipoCamaId])
                         VALUES (@HabitacionId,@CostoHabitacion,@CantCamas,@CantAlmohadas,@CantMesas,@CantSillas,@Observacion,
			                   @CantTVs,@FKTipoAireId,@FKTipoHabitacionId,@FKTipoCamaId)"
        },
        {
            "actualizar", "UPDATE [dbo].[Habitaciones] SET [HabitacionId]=@HabitacionId,[CostoHabitacion]=@CostoHabitacion,[CantCamas]=@CantCamas,
								  [CantAlmohadas]=@CantAlmohadas,[CantMesas]=@CantMesas,[CantSillas]=@CantSillas,[Observacion]=@Observacion,
								  [CantTVs]=@CantTVs,[FKTipoAireId]=@FKTipoAireId,[FKTipoHabitacionId]=@FKTipoHabitacionId,[FKTipoCamaId]=@FKTipoCamaId
						  WHERE HabitacionId=@HabitacionId"
        },
        {
            "obtener_tipo_camas", "SELECT *FROM TipoCamas"
        },
        {
            "obtener_tipo_aires", "SELECT *FROM TipoAiresAcondicionados"
        },
        {
            "obtener_tipo_habitaciones", "SELECT *FROM TipoHabitaciones"
        },
        {
            "obtener_ocupadas", "SELECT Clientes.NombreCliente + ' ' + Clientes.ApellidoCliente as [Nombre del cliente], Ventas.FechaEntrada as [Fecha de entrada],
			                            Ventas.DiasEstadia as [Días de estadía], Habitaciones.HabitacionId as [Número de habitación]
                                 FROM   Ventas INNER JOIN
                                        Clientes ON Ventas.FkClienteId = Clientes.ClienteId INNER JOIN
                                        DetalleHabitaciones ON Ventas.VentaId = DetalleHabitaciones.VentaId INNER JOIN
                                        Habitaciones ON DetalleHabitaciones.HabitacionId = Habitaciones.HabitacionId
                                        WHERE Habitaciones.EstadoDisponibilidad=0 AND DetalleHabitaciones.EstadoDetalle=0"
        },
        {
            "actualizar_detalle", "UPDATE DetalleHabitaciones SET EstadoDetalle=1 
                                   WHERE VentaId=@VentaId"
        },
        {
            "top_vendidas", "SELECT top 5 Concat('Habitación ',DetalleHabitaciones.HabitacionId) as [Número de habitación], 
			                    Count(DetalleHabitaciones.HabitacionId) AS [Total ventas]
                            FROM  Ventas INNER JOIN
                                DetalleHabitaciones ON Ventas.VentaId = DetalleHabitaciones.VentaId
	                        Where Month(Ventas.FechaEntrada) = Month(@Parametro)
                            GROUP BY DetalleHabitaciones.HabitacionId
                            ORDER BY Count(DetalleHabitaciones.HabitacionId) desc"
        }
    }

    'Diccionario con todos los queries relacionados a gastos adicionales
    Public queriesGastos As New Dictionary(Of String, String) From
    {
        {
            "obtener_gastos_venta", "SELECT Productos.NombreProducto as [Nombre del producto], Productos.Precio as [Precio(L)], GastosAdicionales.Cantidad , GastosAdicionales.TotalGasto as [Total del Gasto(L)]
                              FROM   GastosAdicionales INNER JOIN
                                     Ventas ON GastosAdicionales.FkVentaId = Ventas.VentaId INNER JOIN
                                     Productos ON GastosAdicionales.FkProductoId = Productos.ProductoId
                                     WHERE (Ventas.VentaId = @VentaId)"
        },
        {
            "insertar_gasto", "INSERT INTO [dbo].[GastosAdicionales] ([Cantidad],[TotalGasto],[FkProductoId],[FkVentaId])
                               VALUES (@Cantidad, @TotalGasto, @FkProductoId, @FkVentaId)"
        },
        {
            "obtener_gastos", "SELECT Clientes.NombreCliente + ' ' +Clientes.ApellidoCliente as [Cliente], Clientes.ClienteId AS [Número de Identidad], Productos.NombreProducto AS Producto, Productos.Precio as [Precio(L)], GastosAdicionales.Cantidad, 
                                      GastosAdicionales.TotalGasto AS [Total(L)]
                               FROM   GastosAdicionales INNER JOIN
                                      Productos ON GastosAdicionales.FkProductoId = Productos.ProductoId INNER JOIN
                                      Ventas ON GastosAdicionales.FkVentaId = Ventas.VentaId INNER JOIN
                                      Clientes ON Ventas.FkClienteId = Clientes.ClienteId
                                      ORDER BY Ventas.VentaId DESC"
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
        },
        {
            "obtener", "SELECT Empleados.NombreEmpleado AS [Nombre del empleado], Empleados.ApellidoEmpleado AS [Apellido del empleado], Empleados.EmpleadoId AS [Número de identidad], Empleados.Telefono AS [Número de teléfono], 
                               Empleados.Correo AS [Correo electrónico], Cargos.Descripcion AS Cargo, Empleados.FKCargoId
                        FROM   Empleados INNER JOIN
                               Cargos ON Empleados.FKCargoId = Cargos.CargoId
                               WHERE NOT Empleados.EmpleadoId='1'"
        },
        {
            "insertar", "INSERT INTO [dbo].[Empleados]([EmpleadoId],[NombreEmpleado],[ApellidoEmpleado],[Telefono] ,[Correo],[FKCargoId])
                         VALUES (@EmpleadoId,@NombreEmpleado,@ApellidoEmpleado,@Telefono,@Correo,@FKCargoId)"
        },
        {
            "actualizar", "UPDATE [dbo].[Empleados] SET [EmpleadoId] = @EmpleadoId,[NombreEmpleado] = @NombreEmpleado,[ApellidoEmpleado] = @ApellidoEmpleado ,
                                  [Telefono] = @Telefono,[Correo] = @Correo,[FKCargoId] = @FKCargoId
                           WHERE  EmpleadoId=@EmpleadoId"
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
            "obtener_activos", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio AS [Precio(L)]
                                FROM Productos
                                WHERE Productos.EstadoProducto=1"
        },
        {
            "obtener_todos", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio AS [Precio(L)], Productos.EstadoProducto as [Estado del producto]
                              FROM Productos"
        },
        {
            "obtener_producto", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio AS [Precio(L)], Productos.EstadoProducto as [Estado del producto]
                                FROM Productos
                                WHERE Productos.NombreProducto LIKE CONCAT('%', @NombreProducto, '%')"
        },
        {
            "obtener_producto_activo", "SELECT Productos.ProductoId, Productos.NombreProducto as [Nombre del producto], Productos.Precio AS [Precio(L)]
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

    'Diccionario con todos los queries relacionados a cargos de empleados
    Public queriesCargos As New Dictionary(Of String, String) From
    {
        {
            "obtener", "SELECT Cargos.CargoId, Cargos.Descripcion as [Descripción del cargo] FROM Cargos"
        },
        {
            "insertar", "INSERT INTO [dbo].[Cargos] ([Descripcion])
                         VALUES (@Descripcion)"
        },
        {
            "actualizar", "UPDATE [dbo].[Cargos] SET [Descripcion] = @Descripcion
                           WHERE CargoId=@CargoId"
        }
    }

    'Diccionario con todos los queries relacionados a diario de empleados
    Public queriesDiario As New Dictionary(Of String, String) From
    {
        {
            "obtener", "SELECT Empleados.NombreEmpleado + ' ' + Empleados.ApellidoEmpleado as [Nombre del cliente], Empleados.EmpleadoId as [Número de identidad], DiarioEmpleados.Fecha as [Fecha de entrada], DiarioEmpleados.HoraEntrada as [Hora de entrada], DiarioEmpleados.Observacion as [Observación]
                        FROM   DiarioEmpleados INNER JOIN
                               Empleados ON DiarioEmpleados.FkEmpleadoId = Empleados.EmpleadoId"
        },
        {
            "obtener2", "SELECT DiarioEmpleados.DiarioEmpleadoId, Empleados.NombreEmpleado + ' ' + Empleados.ApellidoEmpleado as [Nombre del cliente], Empleados.EmpleadoId as [Número de identidad], DiarioEmpleados.Fecha as [Fecha de entrada], DiarioEmpleados.HoraEntrada as [Hora de entrada], DiarioEmpleados.Observacion as [Observación]
                        FROM   DiarioEmpleados INNER JOIN
                               Empleados ON DiarioEmpleados.FkEmpleadoId = Empleados.EmpleadoId
                               WHERE DiarioEmpleados.EstadoDiario=1"
        },
        {
            "insertar", "INSERT INTO [dbo].[DiarioEmpleados]([Fecha],[HoraEntrada],[Observacion],[FkEmpleadoId])
                         VALUES     (@Fecha,@HoraEntrada,@Observacion,@FkEmpleadoId)"
        },
        {
            "actualizar_salida", "UPDATE DiarioEmpleados SET HoraSalida=@HoraSalida, EstadoDiario=0
                                  WHERE DiarioEmpleadoId=@DiarioEmpleadoId"
        }
    }

    'Diccionario con todos los queries relacionados a los usuarios de los empleados
    Public queriesUsuarios As New Dictionary(Of String, String) From
    {
        {
            "insertar", " INSERT INTO [dbo].[Usuarios]([EmpleadoId],[NombreUsuario],[Contrasenia],[Nivel])
                          VALUES (@EmpleadoId,@NombreUsuario,@Contrasenia,@Nivel)"
        },
        {
            "actualizar", "UPDATE [dbo].[Usuarios] SET [NombreUsuario] = @NombreUsuario,[Contrasenia] = @Contrasenia,[Nivel] = @Nivel
                           WHERE EmpleadoId=@EmpleadoId"
        },
        {
            "obtener", "SELECT Empleados.NombreEmpleado + ' '+ Empleados.ApellidoEmpleado as [Empleado], Empleados.EmpleadoId AS [Número de identidad], Usuarios.NombreUsuario as [Usuario], Usuarios.Contrasenia AS Contraseña, Usuarios.Nivel AS [Nivel de acceso]
                        FROM   Empleados INNER JOIN
                        Usuarios ON Empleados.EmpleadoId = Usuarios.EmpleadoId
                        WHERE NOT Empleados.EmpleadoId='1'"
        },
        {
            "obtener_usuario", "SELECT *FROM Usuarios WHERE NombreUsuario=@NombreUsuario AND Contrasenia=@Contrasenia"
        }
    }

End Module
