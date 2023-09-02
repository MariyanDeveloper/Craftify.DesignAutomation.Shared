namespace Craftify.DesignAutomation.Shared.Extensions;

public static class ProductExtensions
{
    private static readonly string _autodeskName = "Autodesk";
    private static readonly int _minVersion = 2020;
    private static readonly int _maxVersion = 2024;
    public static string GetEngine(this Product product, int version)
    {
        ThrowIfNotSupportedVersion(version);
        return product switch
        {
            Product.Revit => $"{_autodeskName}.{product}+{version}",
            _ => throw new ArgumentException($"Unsupported product: {product}.")
        };
    }
    
    private static void ThrowIfNotSupportedVersion(int version)
    {
        if (version < _minVersion || version > _maxVersion)
        {
            throw new ArgumentOutOfRangeException(nameof(version),
                $"Version must be between {_minVersion} and {_maxVersion}.");
        }
    }
}