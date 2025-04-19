
namespace Top30Algo.tools;

public static class CollectionFormatter {
    /// <summary>
    /// 将集合转换为字符串，支持处理 null 集合和 null 元素。
    /// </summary>
    /// <param name="collection">输入的集合</param>
    /// <param name="separator">分隔符，默认为 ", "</param>
    /// <param name="nullRepresentation">null 元素的表示形式，默认为 "null"</param>
    /// <returns>格式化后的字符串</returns>
    public static string CollectionToString<T>(
        IEnumerable<T>? collection, 
        string separator = ", ", 
        string nullRepresentation = "null"
    ) {
        if (collection == null)
        {
            return "null";
        }

        return string.Join(
            separator, 
            collection.Select(item => 
                item != null ? item.ToString() : nullRepresentation
            )
        );
    }
}