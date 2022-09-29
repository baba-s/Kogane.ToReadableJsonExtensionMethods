namespace Kogane
{
    public static class ToReadableJsonExtensionMethods
    {
        /// <summary>
        /// 指定されたインスタンスを JSON に変換して返します
        /// </summary>
        public static string ToReadableJson<T>( this T self )
        {
            return JsonSerializer.Serialize( self );
        }
    }
}