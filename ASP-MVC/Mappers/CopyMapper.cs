using ASP_MVC.Models.Copy;
using BLL.Entities;

namespace ASP_MVC.Mappers
{
    internal static class CopyMapper
    {
        public static CopyListItem ToListItem(this Copy copy)
        {
            if (copy is null) throw new ArgumentNullException(nameof(copy));
            return new CopyListItem()
            {
                //
            };
        }
    }
}
