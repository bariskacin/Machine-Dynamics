using System.Drawing;

namespace ClassLibrary1
{
    public class Class1
    {
        Graphics grafik;
        Pen KalemBeyaz = new Pen(System.Drawing.Color.White, 10);
        Pen KalemMavi = new Pen(System.Drawing.Color.Blue, 3);
        Pen KalemSari = new Pen(System.Drawing.Color.Yellow, 3);
        Pen KalemKirmizi = new Pen(System.Drawing.Color.Red, 6);
        //Başlangıç değerleri. Tüm fonksiyonlarda kullanılacağından Global tanımlandı. 
        double OrijinX = 200;
        double OrijinY = 300;
        double Ax = 0;
        double Ay = 0;
        double Bx = 0;
        double By = 0;
        double Cx = 0;
        double Cy = 0;
        double Dx = 400;
        double Dy = 0;
        double Aci1 = 180.0, Aci2 = 60, Aci3 = 0, Aci4 = 0; //Dereceler gösterimlerde kullanılıyor
        double Aci2Radyan = 60, Aci3Radyan = 0, Aci4Radyan = 0; //Radyanlar hesaplamalarda kullanılıyor
        double R1 = 400;
        double R2 = 100;
        double R3 = 300;
        double R4 = 250;
    }
}
