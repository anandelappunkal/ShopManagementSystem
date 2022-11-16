namespace ShopManagementSystem.Models
{
    public class SoundBox : BaseEntity
    {

        public string ItemPlan { get; set; }

        public int NoOfItem { get; set; }
        public int Price { get; set; }
        public string  ShopName { get; set; }
        public int ShopId { get; set; }      
        public int CategoryId { get; set; }
    }
}
