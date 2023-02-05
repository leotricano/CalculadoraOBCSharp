using Calculadora.Basicas;

Soma soma1 = new Soma();
Console.WriteLine("Somar "+soma1.Calcular(10,1));

Divisao dividir1 = new Divisao();
Console.WriteLine("Dividir "+dividir1.Calcular(10, 2));

Multiplicador Multiplicando1= new Multiplicador();
Console.WriteLine("Multiplicar "+Multiplicando1.Calcular(10, 1));

Operacoes opera1 = new Operacoes();
Console.WriteLine("Testando opera soma "+opera1.Soma.Calcular(100, 10.1));
Console.WriteLine("Testando opera subtracao " + opera1.Subtracao.Calcular(100, 200));
Console.WriteLine("Testando opera divisao " + opera1.Divisao.Calcular(100, 10));
Console.WriteLine("Testando opera multiplicar " + opera1.Multiplicador.Calcular(100, 10));