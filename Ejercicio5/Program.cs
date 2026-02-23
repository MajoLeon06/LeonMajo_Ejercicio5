Console.WriteLine("SOLICITANTE\n1:Empleado fijo\n2:Temporal\n3:Independiente\n4:Estudiante");
Console.WriteLine("Ingrese tipo de solicitante");
int solicitante = int.Parse(Console.ReadLine());
Console.WriteLine("Ingreso mensual:");
double ingreso = double.Parse(Console.ReadLine());
Console.WriteLine("Antigüedad laboral (en meses):");
int meses = int.Parse(Console.ReadLine());
Console.WriteLine("Monto solicitado:");
double monto = double.Parse(Console.ReadLine());
Console.WriteLine("HISTORIAL\n1:Excelente\n2:Bueno\n3:Regular\n4:Malo");
Console.WriteLine("Ingrese historial crediticio");
int historial = int.Parse(Console.ReadLine());
Console.WriteLine("¿Tiene fiador? 1:Si 2:No");
int fiador = int.Parse(Console.ReadLine());
if (solicitante >= 1 && solicitante <= 4 && historial >= 1 && historial <= 4 && fiador >= 1 && fiador <= 2)
{
    if (ingreso > monto)
    {
        switch (solicitante)
        {
            case 1:
                {
                    if (historial == 1 || historial == 2)
                    {
                        Console.WriteLine("Aprobado por empleado e historial");
                    }
                    else if(historial==3)
                    {
                        Console.WriteLine("Aprobado con condiciones por historial");
                    }
                    else
                    {
                        if (fiador==1)
                        {
                            Console.WriteLine("Aprobado condicionado por tener fiador");
                        }
                        else
                        {
                            Console.WriteLine("Rechazado por mal historial y no tener fiador");
                        }
                    }
                    break;
                }
            case 2:
                {
                    if (historial == 1 || historial == 2)
                    {
                        Console.WriteLine("Aprobado por empleado temporal e historial");
                    }
                    else if (historial == 3)
                    {
                        Console.WriteLine("Aprobado con condiciones por historial");
                    }
                    else
                    {
                        if (fiador == 1)
                        {
                            Console.WriteLine("Aprobado condicionado por tener fiador");
                        }
                        else
                        {
                            Console.WriteLine("Rechazado por mal historial y no tener fiador");
                        }
                    }
                    break;
                }
            case 3:
                {
                    if (monto * 2 > ingreso)
                    {
                        Console.WriteLine("Rechazado, se requieren más ingresos");
                    }
                    else
                    {
                        if (historial == 1 || historial == 2)
                        {
                            Console.WriteLine("Aprobado por historial");
                        }
                        else if (historial == 3)
                        {
                            Console.WriteLine("Aprobado con condiciones por historial");
                        }
                        else
                        {
                            if (fiador == 1)
                            {
                                Console.WriteLine("Aprobado condicionado por tener fiador");
                            }
                            else
                            {
                                Console.WriteLine("Rechazado por mal historial y no tener fiador");
                            }
                        }
                    }
                    break;
                }
        }
    }
    else
    {
        Console.WriteLine("Rechazado por falta de fondos");
    }
}