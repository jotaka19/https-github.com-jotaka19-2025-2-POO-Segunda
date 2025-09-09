using System;

public class Televisao
{
    private int totalCanais = 520;
    private int canalAtual = 1;
    private int ultimoCanal = 1;
    private int volumeAtual = 50;
    private int volumeMax = 100;
    private int volumeMin = 0;
    private bool mudo = false;

    // ----- GERENCIAMENTO DE CANAIS -----
    public void LigarTV()
    {
        canalAtual = ultimoCanal;
        Console.WriteLine($"A TV ligou no canal {canalAtual}");
    }

    public void PassarCanalAcima()
    {
        if (canalAtual < totalCanais)
            canalAtual++;
        Console.WriteLine($"Canal atual: {canalAtual}");
    }

    public void PassarCanalAbaixo()
    {
        if (canalAtual > 1)
            canalAtual--;
        Console.WriteLine($"Canal atual: {canalAtual}");
    }

    public void IrParaCanal(int numero)
    {
        if (numero >= 1 && numero <= totalCanais)
        {
            canalAtual = numero;
            ultimoCanal = numero;
        }
        else
        {
            Console.WriteLine("Canal inválido!");
        }
        Console.WriteLine($"Canal atual: {canalAtual}");
    }

    // ----- GERENCIAMENTO DE VOLUME -----
    public void AumentarVolume()
    {
        if (volumeAtual < volumeMax)
            volumeAtual++;
        Console.WriteLine($"Volume atual: {volumeAtual}");
    }

    public void ReduzirVolume()
    {
        if (volumeAtual > volumeMin)
            volumeAtual--;
        Console.WriteLine($"Volume atual: {volumeAtual}");
    }

    public void AtivarMudo()
    {
        mudo = !mudo;
        if (mudo)
            Console.WriteLine("TV no modo mudo");
        else
            Console.WriteLine($"Mudo desativado. Volume: {volumeAtual}");
    }
}