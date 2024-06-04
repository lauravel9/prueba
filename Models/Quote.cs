namespace prueba.Models
{
    public class Quote
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PetId { get; set; }
        public int VetId { get; set; }
        public string? Descripcion { get; set; }
        public string? Status { get; set; }
        public Pet? Pet { get; set; }
        public Vet? Vet { get; set; } 
    }
}