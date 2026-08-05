Console.WriteLine("=====Conversor de monedas extranjeros basico=====");
Console.WriteLine("Desea realizar alguna Conversion? Responda (Si) para continuar o (No) para terminar el programa de una.");
string resultado = Console.ReadLine();

while (resultado != "No")
{
    Console.WriteLine("Elija la opcion para convertir una moneda especifica en su valor extranjero");
    Console.WriteLine("1. COP a USD");
    Console.WriteLine("2. COP a MEX");
    Console.WriteLine("3. COP a WON");
    Console.WriteLine("4. COP a YEN");
    Console.WriteLine("5. USD a COP");
    Console.WriteLine("6. MEX a COP");
    Console.WriteLine("7. WON a COP");
    Console.WriteLine("8. YEN a COP");

    int opcion = Int32.Parse(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("COP a USD");

            Console.WriteLine("Cuanto COP desea convertir?");
            double cop = Double.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto esta el USD?");
            double usd = Double.Parse(Console.ReadLine());

            if (cop <= 0 && usd <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double cop_usd = cop * (1 / usd);
                Console.WriteLine($"El valor {cop} pesos colombianos a dolares es {cop_usd} usd");
            }
            break;

        case 2:
            Console.WriteLine("COP a MEX");

            Console.WriteLine("Cuanto COP desea convertir?");
            double Cop = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el peso mexicano?");
            double mex = Double.Parse(Console.ReadLine());

            if (Cop <= 0 && mex <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double cop_mex = Cop * (1/mex);
                Console.WriteLine($"El valor {Cop} a pesos mexicanos es {cop_mex} mexicanos");
            }
            break;

        case 3:
            Console.WriteLine("COP a WON");

            Console.WriteLine("Cuanto COP desea convertir?");
            double cOp = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el won?");
            double won = Double.Parse(Console.ReadLine());

            if (cOp <= 0 && won <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double cop_won = cOp * (1 / won);

                Console.WriteLine($"El valor {cOp} a wones es {cop_won} wones");
            }
            break;

        case 4:
            Console.WriteLine("COP a YEN");

            Console.WriteLine("Cuanto COP desea convertir?");
            double peso_cop = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el yen?");
            double yen = Double.Parse(Console.ReadLine());

            if (peso_cop <= 0 && yen <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double cop_yen = peso_cop * (1 / yen);

                Console.WriteLine($"El valor {peso_cop} pesos colombianos a yenes es {cop_yen} yenes ");
            }
            break;

        case 5:
            Console.WriteLine("USD a COP");

            Console.WriteLine("Cuantos dolares desea convertir?");
            double dolar = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el peso colombiano en dolar?");
            double peso_colombiano = Double.Parse(Console.ReadLine());

            if (dolar <= 0 && peso_colombiano <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double usd_cop = dolar * (peso_colombiano/1);
                Console.WriteLine($"El valor de {dolar} dolares a pesos colombianos es {usd_cop} pesos colombianos");
            }
            break;

        case 6:
            Console.WriteLine("MEX a COP");

            Console.WriteLine("Cuantos pesos mexicanos desea convertir?");
            double mexicano = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el peso colombiano a pesos mexicanos?");
            double costeño = Double.Parse(Console.ReadLine());

            if (mexicano <= 0 && costeño <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {
                double mexi_cop = mexicano * (costeño/ 1);
                Console.WriteLine($"El valor de {mexicano} pesos mexicanos a pesos colombianos es {mexi_cop} pesos mexicanos");


            }
            break;

        case 7:
            Console.WriteLine("WON a COP");

            Console.WriteLine("Cuantos wones desea convertir?");
            double wones = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el peso colombiano a wones?");
            double pesos_colombianos = Double.Parse(Console.ReadLine());

            if (wones <= 0 && pesos_colombianos <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {

                double won_cop = wones * (pesos_colombianos / 1);
                Console.WriteLine($"El valor de {wones} wones a pesos colombianos es {won_cop} pesos colombianos");

            }
            break;

        case 8:
            Console.WriteLine("YEN a COP");

            Console.WriteLine("Cuanto YENES desea convertir?");
            double yenes = Double.Parse(Console.ReadLine());

            Console.WriteLine("Cuanto esta el peso colombiano a yenes?");
            double pesitos = Double.Parse(Console.ReadLine());

            if (yenes <= 0 && pesitos <= 0)
            {
                Console.WriteLine("No puede realizar esta operacion con valores negativos");
            }
            else
            {

                double yen_cop = yenes * (pesitos / 1);
                Console.WriteLine($"El valor de {yenes} yenes a pesos colombianos es {yen_cop} pesos colombianos");

            }
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }
    Console.WriteLine("Desea hacer alguna otra conversion? responda (Si) para continuar o (No) para salir");
    resultado = Console.ReadLine();
}
