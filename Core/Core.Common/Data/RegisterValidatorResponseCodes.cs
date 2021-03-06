﻿namespace AFT.RegoV2.Core.Common.Data
{
    public enum RegisterValidatorResponseCodes
    {
        PhysicalAddressLine1Required,
        PhysicalAddressCityRequired,
        PhysicalAddressPostalCodeRequired,
        CurrencyCodeRequired,
        CultureCodeRequired,
        UsernameRequired,
        PasswordRequired,
        PasswordConfirmRequired,
        BrandIdRequired,
        ContactPreferenceRequired,
        AccountStatusRequired,
        IdStatusRequired,
        InvalidCultureCode,
        UsernameLengthIsNotInAllowedRange,
        UsernameFormatIsWrong,
        UsernameAlreadyExists,
        PasswordLengthIsNotInItsAllowedRange,
        ConfirmationPasswordDoesntMatch,
        BrandIsUnknown,
        InvalidContractPreference,
        InvalidSecurityQuestionId,
        SecurityQuestionIdRequired,
        SecurityAnswerIsMissing,
        InvalidIdStatus,
        InvalidPlayerStatus
    }
}
