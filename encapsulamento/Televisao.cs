public class Televisao
{
    private const int VOL_MAX = 100;
    private const int VOL_MIN = 0;
    private const int CANAL_MAX = 520;
    private const int CANAL_MIN = 1;

    private int UltimoCanal = 1;
    private int VolumeAnterior = 10;


    public Televisao(float tamanho)
    {
        Tamanho = tamanho;
        Volume = 10;
        Canal = UltimoCanal;
        Estado = false;
    }

    public float Tamanho {get;}
    public int Resolucao {get; set;}
    public int Volume {get; private set;}
    public int Canal {get; private set;}
    public bool Estado {get; private set;}

    public void Ligar()
    {
        Estado = true;
        Canal = UltimoCanal;
        Console.WriteLine("TV ligada no canal " + Canal);
    }

    public void Desligar()
    {
        Estado = false;
        UltimoCanal = Canal;
        Console.WriteLine("TV desligada.");
    }


    public void AumentarVolume()
    {
        if(Volume < VOL_MAX)
            Volume++;
        else  
            Console.WriteLine("TV já está no max."); 
    }

    public void DiminuirVolume()
    {
        if(Volume > VOL_MIN)
            Volume--;
        else
            Console.WriteLine("TV já está no volume min.");
    }   

    public void AtivarMudo()
    {
        if(Volume > 0)
        {
            VolumeAnterior = Volume;
            Volume = 0;
            Console.WriteLine("Mudo ativado.");
        }
    }

    public void DesativarMudo()
    {
        if(Volume == 0)
        {
            Volume = VolumeAnterior;
            Console.WriteLine("Mudo desativado. Volume voltou para " + Volume);
        }
    }

    public void ProximoCanal()
    {
        if(Canal < CANAL_MAX)
            Canal++;
        else
            Canal = CANAL_MIN;
    }

    public void CanalAnterior()
    {
        if(Canal > CANAL_MIN)
            Canal--;
        else
            Canal = CANAL_MAX;
    }

    public void IrParaCanal(int numero)
    {
        if(numero >= CANAL_MIN && numero <= CANAL_MAX)
            Canal = numero;
        else
            Console.WriteLine("Canal inválido.");
    }
}