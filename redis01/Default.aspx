<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="redis01._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">ASP.NET Session State Provider for Azure Cache for Redis</h1>
            <p class="lead">Azure Cache for Redis provides a session state provider that you can use to store your session state in-memory with Azure Cache for Redis instead of a SQL Server database. To use the caching session state provider, first configure your cache, and then configure your ASP.NET application for cache using the Azure Cache for Redis Session State NuGet package</p>
            <p><a target="_blank" href="https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-aspnet-session-state-provider" class="btn btn-primary btn-md">Microsoft Documentation &raquo;</a></p>
        </section>

        <div class="row">
            <section class="col-md-4" aria-labelledby="gettingStartedTitle">
                <h2 id="gettingStartedTitle">Store ASP.NET session state in the cache</h2>
                <p>
                    To configure a client application in Visual Studio using the Azure Cache for Redis Session State NuGet package, select NuGet Package Manager, Package Manager Console from the Tools menu
                </p>
                <p>
                    <a class="btn btn-default" href="https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-aspnet-session-state-provider">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="librariesTitle">
                <h2 id="librariesTitle">Azure Cache for Redis Session State Provider</h2>
                <p>
                    This provider gives you the best of both worlds. Your Web App can have a simple, fast, and scalable Session State Provider. Because this provider stores the Session state in a Cache, your app has to take in consideration all the characteristics associated when talking to a Distributed In Memory Cache, such as transient network failures. For best practices on using Cache, see Caching guidance from Microsoft Patterns & Practices Azure Cloud Application Design and Implementation Guidance.
                </p>
                <p>
                    <a class="btn btn-default" href="https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-aspnet-session-state-provider">Learn more &raquo;</a>
                </p>
            </section>
            <section class="col-md-4" aria-labelledby="hostingTitle">
                <h2 id="hostingTitle">Important</h2>
                <p>
                    Data stored in the cache must be serializable, unlike the data that can be stored in the default in-memory ASP.NET Session State Provider. When the Session State Provider for Redis is used, be sure that the data types that are being stored in session state are serializable.
                </p>
                <p>
                    <a class="btn btn-default" href="https://learn.microsoft.com/en-us/azure/azure-cache-for-redis/cache-aspnet-session-state-provider">Learn more &raquo;</a>
                </p>
            </section>
        </div>
    </main>

</asp:Content>
