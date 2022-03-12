﻿using System;
using System.Globalization;
using System.Windows;

namespace Paint_Keyboard.Strings
{
    /// <summary>
    /// https://docs.microsoft.com/zh-cn/windows/uwp/publish/supported-languages
    /// </summary>
    public enum LangCode
    {
        ko,
        nl,
        pt,
        ru,
        zh,
        ar,
        de,
        en,
        es,
        fr,
        it,
        ja,
    }

    internal class LanguageResourceDictionary : ResourceDictionary
    {

        //@Static
        public static LangCode Code = GetLangCode(CultureInfo.CurrentCulture.Name);

        public LanguageResourceDictionary()
        {
            LangCode code = LanguageResourceDictionary.Code;
            switch (code)
            {
                case LangCode.ko: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/ko.xaml"); break;
                case LangCode.nl: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/nl.xaml"); break;
                case LangCode.pt: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/pt.xaml"); break;
                case LangCode.ru: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/ru.xaml"); break;
                case LangCode.zh: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/zh-CN.xaml"); break;
                case LangCode.ar: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/ar.xaml"); break;
                case LangCode.de: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/de.xaml"); break;
                case LangCode.en: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/en-US.xaml"); break;
                case LangCode.es: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/es.xaml"); break;
                case LangCode.fr: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/fr.xaml"); break;
                case LangCode.it: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/it.xaml"); break;
                case LangCode.ja: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/ja.xaml"); break;
                default: base.Source = new Uri("pack://Application:,,,/Paint Keyboard;component/Strings/en-US.xaml"); break;
            }
        }

        public static LangCode GetLangCode(string lang)
        {
            switch (lang.ToLower())
            {
                case "af":
                case "af-za":
                    return LangCode.en;
                case "am":
                case "am-et":
                    return LangCode.en;
                case "ar":
                case "ar-ae":
                case "ar-bh":
                case "ar-dz":
                case "ar-eg":
                case "ar-iq":
                case "ar-jo":
                case "ar-kw":
                case "ar-lb":
                case "ar-ly":
                case "ar-ma":
                case "ar-om":
                case "ar-qa":
                case "ar-sa":
                case "ar-sy":
                case "ar-tn":
                case "ar-ye":
                    return LangCode.ar;
                case "as":
                case "as-in":
                    return LangCode.en;
                case "az":
                case "az-arab":
                case "az-arab-az":
                case "az-cyrl":
                case "az-cyrl-az":
                case "az-latn":
                case "az-latn-az":
                    return LangCode.en;
                case "be":
                case "be-by":
                    return LangCode.en;
                case "bg":
                case "bg-bg":
                    return LangCode.en;
                case "bn":
                case "bn-bd":
                case "bn-in":
                    return LangCode.en;
                case "bs":
                case "bs-cyrl":
                case "bs-cyrl-ba":
                case "bs-latn":
                case "bs-latn-ba":
                    return LangCode.en;
                case "ca":
                case "ca-es":
                case "ca-es-valencia":
                    return LangCode.en;
                case "chr-cher":
                case "chr-cher-us":
                case "chr-latn":
                    return LangCode.en;
                case "cs":
                case "cs-cz":
                    return LangCode.en;
                case "cy":
                case "cy-gb":
                    return LangCode.en;
                case "da":
                case "da-dk":
                    return LangCode.en;
                case "de":
                case "de-at":
                case "de-ch":
                case "de-de":
                case "de-li":
                case "de-lu":
                    return LangCode.de;
                case "el":
                case "el-gr":
                    return LangCode.en;
                case "en":
                case "en-011":
                case "en-014":
                case "en-018":
                case "en-021":
                case "en-029":
                case "en-053":
                case "en-au":
                case "en-bz":
                case "en-ca":
                case "en-gb":
                case "en-hk":
                case "en-id":
                case "en-ie":
                case "en-in":
                case "en-jm":
                case "en-kz":
                case "en-mt":
                case "en-my":
                case "en-nz":
                case "en-ph":
                case "en-pk":
                case "en-sg":
                case "en-tt":
                case "en-us":
                case "en-vn":
                case "en-za":
                case "en-zw":
                    return LangCode.en;
                case "es":
                case "es-019":
                case "es-419":
                case "es-ar":
                case "es-bo":
                case "es-cl":
                case "es-co":
                case "es-cr":
                case "es-do":
                case "es-ec":
                case "es-es":
                case "es-gt":
                case "es-hn":
                case "es-mx":
                case "es-ni":
                case "es-pa":
                case "es-pe":
                case "es-pr":
                case "es-py":
                case "es-sv":
                case "es-us":
                case "es-uy":
                case "es-ve":
                    return LangCode.es;
                case "et":
                case "et-ee":
                    return LangCode.en;
                case "eu":
                case "eu-es":
                    return LangCode.en;
                case "fa":
                case "fa-ir":
                    return LangCode.en;
                case "fi":
                case "fi-fi":
                case "fil":
                case "fil-latn":
                case "fil-ph":
                    return LangCode.en;
                case "fr":
                case "fr-011":
                case "fr-015":
                case "fr-021":
                case "fr-029":
                case "fr-155":
                case "fr-be":
                case "fr-ca":
                case "fr-cd":
                case "fr-ch":
                case "fr-ci":
                case "fr-cm":
                case "fr-fr":
                case "fr-ht":
                case "fr-lu":
                case "fr-ma":
                case "fr-mc":
                case "fr-ml":
                case "fr-re":
                case "frc-latn":
                case "frp-latn":
                    return LangCode.fr;
                case "ga":
                case "ga-ie":
                    return LangCode.en;
                case "gd-gb":
                case "gd-latn":
                    return LangCode.en;
                case "gl":
                case "gl-es":
                    return LangCode.en;
                case "gu":
                case "gu-in":
                    return LangCode.en;
                case "ha":
                case "ha-latn":
                case "ha-latn-ng":
                    return LangCode.en;
                case "he":
                case "he-il":
                    return LangCode.en;
                case "hi":
                case "hi-in":
                    return LangCode.en;
                case "hr":
                case "hr-ba":
                case "hr-hr":
                    return LangCode.en;
                case "hu":
                case "hu-hu":
                    return LangCode.en;
                case "hy":
                case "hy-am":
                    return LangCode.en;
                case "id":
                case "id-id":
                    return LangCode.en;
                case "ig-latn":
                case "ig-ng":
                    return LangCode.en;
                case "is":
                case "is-is":
                    return LangCode.en;
                case "it":
                case "it-ch":
                case "it-it":
                    return LangCode.it;
                case "iu-cans":
                case "iu-latn":
                case "iu-latn-ca":
                    return LangCode.en;
                case "ja":
                case "ja-jp":
                    return LangCode.ja;
                case "ka":
                case "ka-ge":
                    return LangCode.en;
                case "kk":
                case "kk-kz":
                    return LangCode.en;
                case "km":
                case "km-kh":
                    return LangCode.en;
                case "kn":
                case "kn-in":
                    return LangCode.en;
                case "ko":
                case "ko-kr":
                case "kok":
                case "kok-in":
                    return LangCode.ko;
                case "ku-arab":
                case "ku-arab-iq":
                    return LangCode.en;
                case "ky-cyrl":
                case "ky-kg":
                    return LangCode.en;
                case "lb":
                case "lb-lu":
                    return LangCode.en;
                case "lo":
                case "lo-la":
                    return LangCode.en;
                case "lt":
                case "lt-lt":
                    return LangCode.it;
                case "lv":
                case "lv-lv":
                    return LangCode.en;
                case "mi":
                case "mi-latn":
                case "mi-nz":
                    return LangCode.en;
                case "mk":
                case "mk-mk":
                    return LangCode.en;
                case "ml":
                case "ml-in":
                    return LangCode.en;
                case "mn-cyrl":
                case "mn-mn":
                case "mn-mong":
                case "mn-phag":
                    return LangCode.en;
                case "mr":
                case "mr-in":
                    return LangCode.en;
                case "ms":
                case "ms-bn":
                case "ms-my":
                    return LangCode.en;
                case "mt":
                case "mt-mt":
                    return LangCode.en;
                case "nb":
                case "nb-no":
                    return LangCode.en;
                case "ne":
                case "ne-np":
                    return LangCode.en;
                case "nl":
                case "nl-be":
                case "nl-nl":
                    return LangCode.nl;
                case "nn":
                case "nn-no":
                    return LangCode.en;
                case "no":
                case "no-no":
                    return LangCode.en;
                case "nso":
                case "nso-za":
                    return LangCode.en;
                case "om":
                case "om-et":
                case "or":
                case "or-in":
                    return LangCode.en;
                case "pa":
                case "pa-arab":
                case "pa-arab-pk":
                case "pa-deva":
                case "pa-in":
                    return LangCode.en;
                case "pl":
                case "pl-pl":
                    return LangCode.en;
                case "prs":
                case "prs-af":
                case "prs-arab":
                    return LangCode.en;
                case "pt":
                case "pt-br":
                case "pt-pt":
                    return LangCode.pt;
                case "quc-latn":
                case "qut-gt":
                case "qut-latn":
                case "quz":
                case "quz-bo":
                case "quz-ec":
                case "quz-pe":
                    return LangCode.en;
                case "ro":
                case "ro-ro":
                    return LangCode.en;
                case "ru":
                case "ru-ru":
                case "rw":
                case "rw-rw":
                    return LangCode.ru;
                case "sd-arab":
                case "sd-arab-pk":
                case "sd-deva":
                    return LangCode.en;
                case "si":
                case "si-lk":
                case "sk":
                case "sk-sk":
                case "sl":
                case "sl-si":
                    return LangCode.en;
                case "sq":
                case "sq-al":
                    return LangCode.en;
                case "sr":
                case "sr-cyrl":
                case "sr-cyrl-ba":
                case "sr-cyrl-cs":
                case "sr-cyrl-me":
                case "sr-cyrl-rs":
                case "sr-latn":
                case "sr-latn-ba":
                case "sr-latn-cs":
                case "sr-latn-me":
                case "sr-latn-rs":
                    return LangCode.en;
                case "sv":
                case "sv-fi":
                case "sv-se":
                    return LangCode.en;
                case "sw":
                case "sw-ke":
                    return LangCode.en;
                case "ta":
                case "ta-in":
                case "te":
                case "te-in":
                    return LangCode.en;
                case "tg-arab":
                case "tg-cyrl":
                case "tg-cyrl-tj":
                case "tg-latn":
                    return LangCode.en;
                case "th":
                case "th-th":
                    return LangCode.en;
                case "ti":
                case "ti-et":
                    return LangCode.en;
                case "tk-cyrl":
                case "tk-cyrl-tr":
                case "tk-latn":
                case "tk-latn-tr":
                case "tk-tm":
                    return LangCode.en;
                case "tn":
                case "tn-bw":
                case "tn-za":
                    return LangCode.en;
                case "tr":
                case "tr-tr":
                case "tt-arab":
                case "tt-cyrl":
                case "tt-latn":
                case "tt-ru":
                    return LangCode.en;
                case "ug-arab":
                case "ug-cn":
                case "ug-cyrl":
                case "ug-latn":
                    return LangCode.en;
                case "uk":
                case "uk-ua":
                    return LangCode.en;
                case "ur":
                case "ur-pk":
                    return LangCode.en;
                case "uz":
                case "uz-cyrl":
                case "uz-latn":
                case "uz-latn-uz":
                    return LangCode.en;
                case "vi":
                case "vi-vn":
                    return LangCode.en;
                case "wo":
                case "wo-sn":
                    return LangCode.en;
                case "xh":
                case "xh-za":
                    return LangCode.en;
                case "yo-latn":
                case "yo-ng":
                    return LangCode.en;
                case "zh":
                case "zh-cn":
                case "zh-hans":
                case "zh-hans-cn":
                case "zh-hans-sg":
                case "zh-hant":
                case "zh-hant-hk":
                case "zh-hant-mo":
                case "zh-hant-tw":
                case "zh-hk":
                case "zh-mo":
                case "zh-sg":
                case "zh-tw":
                    return LangCode.zh;
                case "zu":
                case "zu-za":
                    return LangCode.en;
                default:
                    return LangCode.en;
            }
        }
    }
}
