namespace Processor
{
    class Processor { public string merk; public string tipe; }
    class Intel : Processor { public Intel() { this.merk = "Intel"; } }
    class CoreI3 : Intel { public CoreI3() { this.tipe = "Core i3"; } }
    class CoreI5 : Intel { public CoreI5() { this.tipe = "Core i5"; } }
    class CoreI7 : Intel { public CoreI7() { this.tipe = "Core i7"; } }
    class AMD : Processor { public AMD() { this.merk = "AMD"; } }
    class Ryzen : AMD { public Ryzen() { this.tipe = "RAYZEN"; } }
    class Athlon : AMD { public Athlon() { this.tipe = "ATHLON"; } }
}

namespace Vga
{
    class Vga { public string merk; }
    class Nvidia : Vga { public Nvidia() { this.merk = "Nvidia"; } }
    class AMD : Vga { public AMD() { this.merk = "AMD"; } }
}

class Laptop
{
    public string merk; public string tipe; public Vga.Vga vga; public Processor.Processor processor ;
    public Laptop(Vga.Vga vga, Processor.Processor processor)
    {
        this.vga = vga;
        this.processor = processor;
    }

    public void LaptopDinyalakan() 
    {
        System.Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    {
        System.Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
    //3
    public void GetInformasi()
    {
        System.Console.WriteLine($"Merk vga: {this.vga.merk}");
        System.Console.WriteLine($"Merk processor: {this.processor.merk}");
        System.Console.WriteLine($"Merk vga: {this.processor.tipe}");
    }
}

class ASUS : Laptop { public ASUS(Vga.Vga vga, Processor.Processor processor) : base (vga, processor) { this.merk = "ASUS"; } }
class ACER : Laptop { public ACER(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.merk = "ACER"; } }
class Lenovo : Laptop { public Lenovo(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.merk = "Lenovo"; } }
class ROG : ASUS { public ROG(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "ROG"; } }
class Vivobook : ASUS { 
    public Vivobook(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "Vivobook"; } 
    public void Ngoding()
    {
        System.Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}
class Swift : ACER { public Swift(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "Swift"; } }
class Predator : ACER { 
    public Predator(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "Predator"; } 
    public void BermainGame()
    {
        System.Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}
class IdeaPad : Lenovo { public IdeaPad(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "IdeaPad"; } }
class Legion : Lenovo { public Legion(Vga.Vga vga, Processor.Processor processor) : base(vga, processor) { this.tipe = "Legion"; } }

class Program
{
    static void Main(string[] args)
    {
        Vga.Nvidia nvidia = new Vga.Nvidia();
        Vga.AMD amd = new Vga.AMD();
        Processor.CoreI5 corei5 = new Processor.CoreI5();
        Processor.CoreI7 corei7 = new Processor.CoreI7();
        Processor.Ryzen ryzen = new Processor.Ryzen();
        Laptop laptop1 = new Vivobook(nvidia,corei5);
        Laptop laptop2 = new IdeaPad(amd,ryzen);
        Predator predator = new Predator(amd,corei7);

        //1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //2
        laptop1.Ngoding();

        //3
        System.Console.WriteLine($"Merk vga: {laptop1.vga.merk}");
        System.Console.WriteLine($"Merk processor: {laptop1.processor.merk}");
        System.Console.WriteLine($"Merk vga: {laptop1.processor.tipe}");
        laptop1.GetInformasi();

        //4
        predator.BermainGame();

        //5
        ACER acer = new Predator(amd, corei7);
        acer.BermainGame();
    }
}