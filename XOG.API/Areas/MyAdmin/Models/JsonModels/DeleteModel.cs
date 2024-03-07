namespace XOG.Areas.MyAdmin.Models.JsonModels
{
    public class DeleteModel
    {
        public RecordType Type { get; set; }
        public long Id { get; set; } 
        public object contentModel { get; set; } 
    }

    public class DeleteMultipleModel
    {
        public RecordType Type { get; set; }
        public string Ids { get; set; }
        public object contentModel { get; set; } 
    }
}