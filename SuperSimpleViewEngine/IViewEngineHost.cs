namespace SuperSimpleViewEngine
{
    /// <summary>
    /// Provides the view engine with utility functions for
    /// encoding, locating partial view templates etc.
    /// </summary>
    public interface IViewEngineHost
    {
        /// <summary>
        /// Html "safe" encode a string
        /// </summary>
        /// <param name="input">Input string</param>
        /// <returns>Encoded string</returns>
        string HtmlEncode(string input);

        /// <summary>
        /// Get the contenst of a template
        /// </summary>
        /// <param name="templateName">Name/location of the template</param>
        /// <returns>Contents of the template, or null if not found</returns>
        string GetTemplate(string templateName);

        /// <summary>
        /// Gets a uri string for a named route
        /// </summary>
        /// <param name="name">Named route name</param>
        /// <param name="parameters">Parameters to use to expand the uri string</param>
        /// <returns>Expanded uri string, or null if not found</returns>
        string GetUriString(string name, params string[] parameters);
    }
}