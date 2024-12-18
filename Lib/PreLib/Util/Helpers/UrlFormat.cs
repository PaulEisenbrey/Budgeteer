namespace Utilities.Helpers;

public class UrlFormat
{
    private readonly string urlPrefix;

    public UrlFormat(string urlPrefix)
    {
        this.urlPrefix = urlPrefix;
    }

    public string CreateUrlPath(string resolverAction)
    {
        return StringHelpers.CombinePath(urlPrefix, resolverAction);
    }

    public string CreateUrlPath(string resolverAction, string replacementTag, string replacementString)
    {
        return StringHelpers.CombinePath(urlPrefix, resolverAction).ReplaceInString(replacementTag, replacementString);
    }
}