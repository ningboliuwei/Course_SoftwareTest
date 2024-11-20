namespace TinyShop.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }

        public bool ShowRequestId {
            get { return !string.IsNullOrEmpty(this.RequestId); }
        }
    }
}