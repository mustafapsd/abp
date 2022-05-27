// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.SettingManagement;

// ReSharper disable once CheckNamespace
namespace Volo.Abp.SettingManagement.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IEmailSettingsAppService), typeof(EmailSettingsClientProxy))]
public partial class EmailSettingsClientProxy : ClientProxyBase<IEmailSettingsAppService>, IEmailSettingsAppService
{
    public virtual async Task<EmailSettingsDto> GetAsync()
    {
        return await RequestAsync<EmailSettingsDto>(nameof(GetAsync));
    }

    public virtual async Task UpdateAsync(UpdateEmailSettingsDto input)
    {
        await RequestAsync(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(UpdateEmailSettingsDto), input }
        });
    }

    public virtual async Task SendTestEmailAsync(SendTestEmailInput input)
    {
        await RequestAsync(nameof(SendTestEmailAsync), new ClientProxyRequestTypeValue
        {
            { typeof(SendTestEmailInput), input }
        });
    }
}
