namespace DemoMVC.Models
{
    public class BMIModel
    {
        public double ChieuCao { get; set; } 
        public double CanNang { get; set; } 

        public double TinhBMI()
        {
            return CanNang / (ChieuCao * ChieuCao);
        }
    }
}