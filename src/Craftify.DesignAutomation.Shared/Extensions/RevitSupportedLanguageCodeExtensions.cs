namespace Craftify.DesignAutomation.Shared.Extensions;

public static class RevitSupportedLanguageCodeExtensions
{
    public static string GetCode(this RevitSupportedLanguage language) => language switch
    {
        RevitSupportedLanguage.AmericanEnglish => "ENU",
        RevitSupportedLanguage.BritishEnglish => "ENG",
        RevitSupportedLanguage.French => "FRA",
        RevitSupportedLanguage.German => "DEU",
        RevitSupportedLanguage.Italian => "ITA",
        RevitSupportedLanguage.Japanese => "JPN",
        RevitSupportedLanguage.Korean => "KOR",
        RevitSupportedLanguage.Polish => "PLK",
        RevitSupportedLanguage.Spanish => "ESP",
        RevitSupportedLanguage.SimplifiedChinese => "CHS",
        RevitSupportedLanguage.TraditionalChinese => "CHT",
        RevitSupportedLanguage.BrazilianPortuguese => "PTB",
        RevitSupportedLanguage.Czech => "CSY",
        _ => throw new NotImplementedException($"Given language : {language} doesn't have code ")
    };
}