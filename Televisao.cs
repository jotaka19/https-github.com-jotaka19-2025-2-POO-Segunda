using System;

class Program
{
    static void Main(string[] args)
    {
        Televisao tv = new Televisao();

        tv.LigarTV();

        // Testes de canais
        tv.IrParaCanal(10);
        tv.PassarCanalAcima();
        tv.PassarCanalAbaixo();
        tv.IrParaCanal(600); // inválido

        // Testes de volume
        tv.AumentarVolume();
        tv.ReduzirVolume();
        tv.AtivarMudo();
        tv.AtivarMudo();
    }
}