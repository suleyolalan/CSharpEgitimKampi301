using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities(); //bu satır normalde btnList içindeydi ama diğer butonların da içine yazacağız. E her seferinde tek tek yazmak yerine parantez dışına aldık
       
        private void btnList_Click(object sender, EventArgs e) //Listele tuşu özellikleri
        {
           
            var values=db.Guide.ToList(); // mesela noktadan sonra çıkan bütün metotlar entity'nin tolları ToList: bütün listeyi gösterecek
            dataGridView1.DataSource = values; // datagrid aracının datasource veri kısmı = values ını yazdır demiş olduk // hepsini listelemiş oldu
        }

        private void btnAdd_Click(object sender, EventArgs e) // ekle tuşunun özelliklerinin olduğu kod kısmı
        {
            Guide guide = new Guide();
            guide.GuideName = txtName.Text;
            guide.GuideSurname= txtSurname.Text;
            db.Guide.Add(guide); // Guide tablosunun içine ekle. Neyi? 34.satırdaki küçük guide'ı. O guide neyi tutuyor? 35 ve 36.satırdaki değerleri
            db.SaveChanges(); //değişiklikleri veritabanına kaydetmek için
            MessageBox.Show("Rehber başarıyla eklendi");
        }
        private void button3_Click(object sender, EventArgs e) // buton adını btnDelete yaptığım halde button3 yapmakta ısrarcı anlamadım
        {
            int id = int.Parse(txtId.Text);
            var removeValue = db.Guide.Find(id); //silme işlemi önemli! çünkü soyadlar aynı olabilir isimler aynı olabilir fakat ID'ler aynı olamaz o yüzden silerken
                                                 //ID'yi atıyorum burda Find(id) ile sonra o satırı tamamen siliyor yani önemli olan id 
            db.Guide.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla silindi");
        }

        private void btnUpdate_Click(object sender, EventArgs e) //güncelle tuşunun özelliklerini giriyoruz
        {
            int id = int.Parse(txtId.Text);
            var updateValue = db.Guide.Find(id);
            updateValue.GuideName = txtName.Text; // Guidname'deki değer artık txtName yani benim, kullanıcının yazacağı değerden gelsin demek oluyor
            updateValue.GuideSurname = txtSurname.Text;
            db.SaveChanges();
            MessageBox.Show("Rehber başarıyla güncellendi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); //parametreli yaptık, Uyarı adında bir pencere açılıyor ve sarı bir Warning Uyarı İkonu eklemiş olduk
        }

        private void btnGetByID_Click(object sender, EventArgs e) // son tuşumuz Id'ye göre getir özellikleri
        {
            int id = int.Parse (txtId.Text);
            var values = db.Guide.Where(x => x.GuideId == id).ToList();   //where şartları "x öyle ki" anlamı kattık
            dataGridView1.DataSource = values; // bütün değerleri getirmeyecek sadece yukardaki şartı sağlayanları getirmiş olacak // şart koyduk
        }
    }
}
