﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FileManagement.Web.Api.Common
{
    public static class Errors
    {
        public static ModelStateDictionary AddErrorsToModelState(IdentityResult identityResult, ModelStateDictionary modelState)
        {
            foreach (var error in identityResult.Errors)
            {
                modelState.TryAddModelError(error.Code, error.Description);
            }

            return modelState;
        }
    }
}