namespace Makine_Dinamiği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {
            grafik = pictureBox1.CreateGraphics();
        }

        //****************** MEKANİZMA ÇALIŞTIR ****************************
        private void btnMekanizmayi_Calistir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        //****************** MEKANİZMA DURDUR ****************************
        private void btnMekanizmayi_Durdur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AcilariVeKonumlariHesapla(Aci2);
            MekanizmaCiziminiGoster();
            VektorelKonumTablosunuGoster();
            MafsalKonumTablosunuGoster();
            MafsalNoktalariniCizimleGoster();
            Aci2++; //Aci2 motorun bağlı olduğu açıdır. Burada saat her tik attığında açıyı artırıyor.  
            Aci2 = Aci2 % 360; //360 dereceyi geçtiğinde tekrar sıfırlamak için Mod (kalan)kullanıldı.
            txtTahrikAcisi.Text = Aci2.ToString(); //Mekanizmayı döndüren tahrik açısı. Yani motorun açısı.
        }

        //****************** BELLİ BİR AÇIDA ÇALIŞTIR ****************************
        private void btnMekanizmayi_Belli_Bir_Acida_Calistir_Click(object sender, EventArgs e)
        {
            Aci2 = Convert.ToDouble(txtTahrikAcisi.Text);
            AcilariVeKonumlariHesapla(Aci2);
            MekanizmaCiziminiGoster();
            VektorelKonumTablosunuGoster();
            MafsalKonumTablosunuGoster();
            MafsalNoktalariniCizimleGoster();
        }

        //************************* HESAPLA VE GÖSTER ********************* 
        public void AcilariVeKonumlariHesapla(double Aci2)
        {
            Bx = Ax + R2 * Math.Cos(Radyan(Aci2));
            By = Ay + R2 * Math.Sin(Radyan(Aci2));
            Aci3Radyan = Aci3Hesapla(Radyan(Aci2)); //Alt fonksiyona giderken Aci2 yi radyana çevirip götürüyor.
            Cx = Bx + R3 * Math.Cos(Aci3Radyan);
            Cy = By + R3 * Math.Sin(Aci3Radyan);
            Aci4Radyan = Aci4Hesapla();
        }

        //SONUÇLARI GÖSTERME***************** 
        public void MekanizmaCiziminiGoster()
        {
            //Her çizimden önce ekranı temizleyip mekanızmayı yeniden çiziyor. Böylece mekanizma hareket etmiş görünüyor. 
            pictureBox1.Refresh();
            //MEKANİZMA çubuklarını grafik ekranda ÇİZDİRİYOR. 
            CizgiCiz(KalemKirmizi, Ax, Ay, Bx, By);
            CizgiCiz(KalemSari, Bx, By, Cx, Cy);
            CizgiCiz(KalemMavi, Cx, Cy, Dx, Dy);
            //Vektörel KONUM TABLOSUNU Ekranda GÖSTERİYOR 
            txtTahrikAcisi.Text = Aci2.ToString(); //Mekanizmayı döndüren tahrik açısı. Yani motorun açısı.
            txtR1_L.Text = R1.ToString();
            txtR1_θ.Text = Aci1.ToString();
            txtR2_L.Text = R2.ToString();
            txtR2_θ.Text = Aci2.ToString();
            txtR3_L.Text = R3.ToString();
            txtR3_θ.Text = (Derece(Aci3Radyan) % 360).ToString(); //Acilar derece olarak ve 360ın modu şeklinde(kalanı şeklinde) gösteriliyor
            txtR4_L.Text = R4.ToString();
            txtR4_θ.Text = (Derece(Aci4Radyan) % 360).ToString(); //Acilar derece olarak ve 360ın modu şeklinde(kalanı şeklinde) gösteriliyor
        }
        public void VektorelKonumTablosunuGoster()
        {
            //Vektörel KONUM TABLOSUNU Ekranda GÖSTERİYOR

            txtR1_L.Text = R1.ToString();
            txtR1_θ.Text = Aci1.ToString();

            txtR2_L.Text = R2.ToString();
            txtR2_θ.Text = Aci2.ToString();

            txtR3_L.Text = R3.ToString();
            txtR3_θ.Text = (Derece(Aci3Radyan) % 360).ToString(); //Acilar derece olarak ve 360ın modu şeklinde (kalanı şeklinde) gösteriliyor

            txtR4_L.Text = R4.ToString();
            txtR4_θ.Text = (Derece(Aci4Radyan) % 360).ToString(); //Acilar derece olarak ve 360ın modu şeklinde (kalanı şeklinde) gösteriliyor
        }
        public void MafsalKonumTablosunuGoster()
        {
            txtAx.Text = Ax.ToString();
            txtAy.Text = Ay.ToString();
            txtBx.Text = Bx.ToString();
            txtBy.Text = By.ToString();
            txtCx.Text = Cx.ToString();
            txtCy.Text = Cy.ToString();
            txtDx.Text = Dx.ToString();
            txtDy.Text = Dy.ToString();
        }
        public void MafsalNoktalariniCizimleGoster()
        {
            DaireCiz(KalemBeyaz, Ax, Ay);
            DaireCiz(KalemBeyaz, Bx, By);
            DaireCiz(KalemBeyaz, Cx, Cy);
            DaireCiz(KalemBeyaz, Dx, Dy);
        }
        public void CizgiCiz(Pen Kalem, double X1, double Y1, double X2, double Y2)
        {
            //Dikkat orijini ekranın sol üst köşesinden ortaya taşıyor (OrijinX, OrijinY). Ayrıca ekranda y eksenleri aşağı baktığından bunları yukarı çevirmek için -1 ile çarpıyor)  
            grafik.DrawLine(Kalem, (int)(X1 + OrijinX), (int)(Y1 * (-1) + OrijinY),(int)(X2 + OrijinX), (int)(Y2 * (-1) + OrijinY));
        }
        public void DaireCiz(Pen Kalem, double X, double Y)
        {
            //Dikkat orijini ekranın sol üst köşesinden ortaya taşıyor (OrijinX, OrijinY). Ayrıca ekranda y eksenleri aşağı baktığından bunları yukarı çevirmek için -1 ile çarpıyor)  
            grafik.DrawEllipse(Kalem, (int)((X) + OrijinX), (int)((Y) * (-1) + OrijinY), 1, 1); //Genişliği ve yüksekliği 1 piksel bir daire çiziyor. Daire gözükmesi için Kalem çapı yukarıda 10 piksel yapıldı. 
        }

        //************ ACI3 HESAPLANIYOR ************************** 
        double m = 0; //Bu değişken Aci4 hesaplarken de kullanılacağından globalde tanımlandı.
        double AciAlfaRadyan = 0; //Bu değişken Aci4 hesaplarken de kullanıldığından tanımlama Globalde yapıldı.
        double AciBetaRadyan = 0;

        public double Aci3Hesapla(double Aci2Radyan)
        {
            double y = R2 * Math.Sin(Aci2Radyan);
            double x = R2 * Math.Cos(Aci2Radyan);
            double z = R1 - x;

            m = Math.Sqrt(y * y + z * z);

            AciAlfaRadyan = Math.Atan(y / z);

            AciBetaRadyan = Math.Acos((R3 * R3 + m * m - R4 * R4) / (2 * R3 * m));

            Aci3Radyan = AciBetaRadyan - AciAlfaRadyan;

            return Aci3Radyan;
        }

        //************ ACI4 HESAPLANIYOR ************************** 
        public double Aci4Hesapla()
        {
            double AciGamaRadyan = Math.Acos((R4 * R4 + m * m - R3 * R3) / (2 * R4 * m));

            Aci4Radyan = 2 * Math.PI - (AciAlfaRadyan + AciGamaRadyan); //Dikkat: 360 derece 2Pi olarak radyan cinsinden yazıldı.
            return Aci4Radyan;
        }

        //Derece gelen açıları Radyan'a dönüştürürüyor 
        public double Radyan(double AciDerece)
        {
            double AciRadyan = AciDerece * 2 * Math.PI / 360.0;
            return AciRadyan;
        }

        //Radyan gelen açıları Dereceye dönüştürüyor 
        public double Derece(double AciRadyan)
        {
            double AciDerece = (AciRadyan * 360.0) / (2 * Math.PI);
            return AciDerece;
        }
    } 
}
