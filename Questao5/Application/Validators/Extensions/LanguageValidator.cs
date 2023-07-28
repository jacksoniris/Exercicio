using FluentValidation;
using FluentValidation.Resources;
using System.Globalization;

namespace Questao5.Application.Validators.Extensions
{
    public class LanguageValidator : LanguageManager
    {
        public LanguageValidator()
        {
            AddTranslation("en", "NotNullValidator", "'{PropertyName}' is required.");
            AddTranslation("en", "OnlyDigitsValidator", "'{PropertyName}' only accepts digits.");
            AddTranslation("en", "GuidValidator", "'{PropertyName}' must not be empty.");
            AddTranslation("en", "ExactLengthValidator2", "'{PropertyName}' must be exact {MaxLength} characters in length.");
            AddTranslation("en", "LengthValidator2", "'{PropertyName}' must be between {MinLength} and {MaxLength} characters");
            AddTranslation("en", "MutualExcludeTemplateValidator", "You must choose to pass Template field or TemplateId field.");
            AddTranslation("en", "AtLeastOneTemplateValidator", "It is needed to pass at least one Template field or one TemplateId field.");
        }
        private static string GetMessage(string key, string propertyName, object parameters = null, CultureInfo culture = null)
        {
            var result = ValidatorOptions.Global.LanguageManager.GetString(key, culture);
            var messageBuilder = ValidatorOptions.Global.MessageFormatterFactory();
            messageBuilder.AppendArgument("PropertyName", propertyName);
            if (parameters != null)
            {
                parameters.GetType().GetProperties().ToList().ForEach(property =>
                {
                    messageBuilder.AppendArgument(property.Name, property.GetValue(parameters));
                });
            }
            result = messageBuilder.BuildMessage(result);

            return result;
        }

        public static string GetEnumValidator(string propertyName)
        {
            return GetMessage("EnumValidator", propertyName);
        }

        public static string GetEmailValidator(string propertyName)
        {
            return GetMessage("EmailValidator", propertyName);
        }

        public static string GetEqualValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("EqualValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetGreaterThanValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("GreaterThanValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetGreaterThanOrEqualValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("GreaterThanOrEqualValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetLengthValidator(string propertyName, object minLength, object maxLength, object totalLength)
        {
            return GetMessage("LengthValidator", propertyName, new { MinLength = minLength, MaxLength = maxLength, TotalLength = totalLength });
        }

        public static string GetLengthValidator2(string propertyName, object minLength, object maxLength)
        {
            return GetMessage("LengthValidator2", propertyName, new { MinLength = minLength, MaxLength = maxLength });
        }

        public static string FormatValidator(string propertyName, object minLength, object maxLength)
        {
            return GetMessage("FormatValidator", propertyName, new { MinLength = minLength, MaxLength = maxLength });
        }

        public static string GetMinimumLengthValidator(string propertyName, object minLength, object totalLength)
        {
            return GetMessage("MinimumLengthValidator", propertyName, new { MinLength = minLength, TotalLength = totalLength });
        }

        public static string GetMinimumLengthValidator2(string propertyName, object minLength)
        {
            return GetMessage("MinimumLengthValidator2", propertyName, new { MinLength = minLength });
        }

        public static string GetMaximumLengthValidator(string propertyName, object maxLength, object totalLength)
        {
            return GetMessage("MaximumLengthValidator", propertyName, new { MinLength = maxLength, MaxLength = maxLength, TotalLength = totalLength });
        }

        public static string GetMaximumLengthValidator2(string propertyName, object maxLength)
        {
            return GetMessage("MaximumLengthValidator2", propertyName, new { MinLength = maxLength, MaxLength = maxLength });
        }

        public static string GetLessThanValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("LessThanValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetLessThanOrEqualValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("LessThanOrEqualValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetNotEmptyValidator(string propertyName)
        {
            return GetMessage("NotEmptyValidator", propertyName);
        }

        public static string GetNotEqualValidator(string propertyName, object comparisonValue)
        {
            return GetMessage("NotEqualValidator", propertyName, new { ComparisonValue = comparisonValue });
        }

        public static string GetNotNullValidator(string propertyName)
        {
            return GetMessage("NotNullValidator", propertyName);
        }

        public static string GetNullValidator(string propertyName)
        {
            return GetMessage("NullValidator", propertyName);
        }

        public static string GetPredicateValidator(string propertyName)
        {
            return GetMessage("PredicateValidator", propertyName);
        }

        public static string GetAsyncPredicateValidator(string propertyName)
        {
            return GetMessage("AsyncPredicateValidator", propertyName);
        }

        public static string GetRegularExpressionValidator(string propertyName)
        {
            return GetMessage("RegularExpressionValidator", propertyName);
        }

        public static string GetExactLengthValidator(string propertyName, object maxLength, object totalLength)
        {
            return GetMessage("ExactLengthValidator", propertyName, new { MaxLength = maxLength, TotalLength = totalLength });
        }

        public static string GetExactLengthValidator2(string propertyName, object maxLength)
        {
            return GetMessage("ExactLengthValidator2", propertyName, new { MaxLength = maxLength });
        }

        public static string GetExclusiveBetweenValidator(string propertyName, object from, object to)
        {
            return GetMessage("ExclusiveBetweenValidator", propertyName, new { From = from, To = to });
        }

        public static string GetInclusiveBetweenValidator(string propertyName, object from, object to)
        {
            return GetMessage("InclusiveBetweenValidator", propertyName, new { From = from, To = to });
        }

        public static string GetEmptyValidator(string propertyName)
        {
            return GetMessage("EmptyValidator", propertyName);
        }

        public static string GetScalePrecisionValidator(string propertyName, object ExpectedPrecision, object ExpectedScale)
        {
            return GetMessage("ScalePrecisionValidator", propertyName, new { expectedPrecision = ExpectedPrecision, expectedScale = ExpectedScale });
        }

        public static string GetGuidValidator(string propertyName)
        {
            return GetMessage("GuidValidator", propertyName);
        }

        public static string GetFieldNotInformedValidator(string propertyName, string fieldName)
        {
            return GetMessage("FieldNotInformedValidator", propertyName, new { FieldName = fieldName });
        }

        public static string GetFieldNotInUseValidator(string propertyName)
        {
            return GetMessage("FieldNotInUseValidator", propertyName);
        }

        public static string GetFieldInUseValidator(string propertyName)
        {
            return GetMessage("FieldInUseValidator", propertyName);
        }

        public static string GetInvalidImageValidator(string propertyName)
        {
            return GetMessage("InvalidImageValidator", propertyName);
        }

        public static string GetForeignKeyValidator(string propertyName)
        {
            return GetMessage("ForeignKeyValidator", propertyName);
        }

        public static string GetUniqueValidator(string propertyName)
        {
            return GetMessage("UniqueValidator", propertyName);
        }

        public static string GetNotAllowedValidator()
        {
            return GetMessage("NotAllowedValidator", "");
        }

        public static string GetOnlyDigitsValidator(string propertyName)
        {
            return GetMessage("OnlyDigitsValidator", propertyName);
        }
    }
}
