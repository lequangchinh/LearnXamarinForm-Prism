﻿// <auto-generated />
using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Text;
using Refit;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

/* ******** Hey You! *********
 *
 * This is a generated file, and gets rewritten every time you build the
 * project. If you want to edit it, you need to edit the mustache template
 * in the Refit package */

#pragma warning disable
namespace Task_Week6.RefitInternalGenerated
{
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [AttributeUsage (AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
    sealed class PreserveAttribute : Attribute
    {

        //
        // Fields
        //
        public bool AllMembers;

        public bool Conditional;
    }
}
#pragma warning restore

namespace Task_Week6.ViewModels
{
    using Task_Week6.RefitInternalGenerated;

    /// <inheritdoc />
    [global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
    [global::System.Diagnostics.DebuggerNonUserCode]
    [Preserve]
    [global::System.Reflection.Obfuscation(Exclude=true)]
    partial class AutoGeneratedIAppAPI : IAppAPI
    {
        /// <inheritdoc />
        public HttpClient Client { get; protected set; }
        readonly IRequestBuilder requestBuilder;

        /// <inheritdoc />
        public AutoGeneratedIAppAPI(HttpClient client, IRequestBuilder requestBuilder)
        {
            Client = client;
            this.requestBuilder = requestBuilder;
        }

        /// <inheritdoc />
        Task<ObservableCollection<Photo>> IAppAPI.GetListImage(string albumId)
        {
            var arguments = new object[] { albumId };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetListImage", new Type[] { typeof(string) });
            return (Task<ObservableCollection<Photo>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<User> IAppAPI.GetUser(string userID)
        {
            var arguments = new object[] { userID };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUser", new Type[] { typeof(string) });
            return (Task<User>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<User>> IAppAPI.GetUsers()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetUsers", new Type[] {  });
            return (Task<List<User>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Album>> IAppAPI.GetAlbums(string userID)
        {
            var arguments = new object[] { userID };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAlbums", new Type[] { typeof(string) });
            return (Task<List<Album>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<Album> IAppAPI.GetAlbum(string albumID)
        {
            var arguments = new object[] { albumID };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetAlbum", new Type[] { typeof(string) });
            return (Task<Album>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Post>> IAppAPI.GetPosts()
        {
            var arguments = new object[] {  };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetPosts", new Type[] {  });
            return (Task<List<Post>>)func(Client, arguments);
        }

        /// <inheritdoc />
        Task<List<Comment>> IAppAPI.GetComments(string postId)
        {
            var arguments = new object[] { postId };
            var func = requestBuilder.BuildRestResultFuncForMethod("GetComments", new Type[] { typeof(string) });
            return (Task<List<Comment>>)func(Client, arguments);
        }
    }
}