// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Threading.Tasks;
using AntDesign;
using Microsoft.AspNetCore.Components;

public class SplitterPanel : ComponentBase, IDisposable
{
    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string DefaultSize { get; set; }

    [Parameter]
    public string Min { get; set; }

    [Parameter]
    public string Max { get; set; }

    [Parameter]
    public string Size { get; set; } = "50%";

    [Parameter]
    public bool Collapsible { get; set; }

    [Parameter]
    public bool Resizable { get; set; } = true;

    [CascadingParameter]
    private Splitter Splitter { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Splitter?.AddPane(this);
    }

    public void Dispose()
    {
        Splitter?.RemovePane(this);
    }

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        var isSizeChanged = parameters.IsParameterChanged(nameof(Size), Size);
        var isResizableChanged = parameters.IsParameterChanged(nameof(Resizable), Resizable);

        await base.SetParametersAsync(parameters);

        if (isSizeChanged || isResizableChanged)
        {
            Splitter.UpdatePaneState();
        }
    }
}