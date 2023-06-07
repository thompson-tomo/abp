﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace Volo.Abp.TextTemplating;

public interface ITemplateDefinitionManager
{
    [NotNull]
    Task<TemplateDefinition> GetAsync([NotNull] string name);

    [NotNull]
    Task<IReadOnlyList<TemplateDefinition>> GetAllAsync();

    [CanBeNull]
    Task<TemplateDefinition> GetOrNullAsync(string name);
}
