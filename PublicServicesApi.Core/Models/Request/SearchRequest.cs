
namespace PublicServicesApi.Core.Models.Request
{
    public class SearchRequest
    {
        public SearchRequest() { }
        public SearchRequest(int pageIndex, int elementsPerPage, FlatInfoRequest flatInfo)
        {
            PageIndex = pageIndex;
            ElementsPerPage = elementsPerPage;
            FlatInfo = flatInfo;
        }
        public int PageIndex { get; set; }
        public int ElementsPerPage { get; set; }

        public FlatInfoRequest FlatInfo { get; set; }
    }
}
