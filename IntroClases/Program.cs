// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Televisor lg = new Televisor();
Televisor samsung = new Televisor();
Televisor sony = new Televisor();

samsung.marca = "Samsung";
samsung.color = "Azul";
samsung.resolucion = 1080;
samsung.tecnologia = "Plasma";
samsung.tamanho = 240;
samsung.entrada = new[] { "HDMI", "RCA", "USB", "TDT" };
samsung.volumen = 0;
samsung.canal = 10;

sony.marca = "Sony";
sony.color = "Negro";
sony.resolucion = 1080;
sony.tecnologia = "LED";
sony.tamanho = 512;
sony.entrada = new[] { "HDMI", "RCA", "USB", "TDT", "VGA", "DVI" };
sony.volumen = 0;
sony.canal = 18;

lg.marca = "lg";
lg.color = "Gris";
lg.resolucion = 1920;
lg.tecnologia = "LCD";
lg.tamanho = 240;
lg.entrada = new[] { "HDMI", "RCA", "TDT" };
lg.volumen = 0;
lg.canal = 15;

/*Console.WriteLine(samsung.canal);
Console.WriteLine(sony.canal);
Console.WriteLine(lg.canal);*/

Televisor[] tienda;

tienda = new[] { lg, sony, samsung };

/*
for (int i = 0; i < tienda.Length; i++)
{
    Console.WriteLine(tienda[i].marca);
    Console.WriteLine(tienda[i].canal);
    for (int j = 0; j < tienda[i].entrada.Length; j++)
    {
        Console.Write(tienda[i].entrada[j]+"\t");
    }
    Console.WriteLine();

}
*/


Console.WriteLine(samsung.marca);
Console.WriteLine(samsung.encendido);
samsung.encender();
Console.WriteLine(samsung.encendido);
samsung.control();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.encender();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();
samsung.subirVol();
samsung.status();






class Televisor
{
    public string marca;
    public string color;
    public int resolucion;
    public string tecnologia;
    public int tamanho;
    public bool encendido = false;
    public string[] entrada;
    public byte volumen;
    public int canal;

    public void control()
    {
        Console.WriteLine(" 1 para encender\n 2 para subir volumen\n 3 para bajar canal");
    }

    public void status()
    {
        Console.WriteLine($"-----\nencendido:\t{encendido}\nvol:\t {volumen}\ncanal:\t {canal}");
    }
    
    public void encender()
    {
        encendido = !encendido;
    }

    public void subirVol()
    {
        if (volumen < 10)
        {
            volumen++;
        }
        else
        {
            volumen = 10;
        }
    }

    public void reducirCanal()
    {
        if (canal == 0)
        {
            canal=100;
        }
        else
        {
            canal--;
        }
    }
}