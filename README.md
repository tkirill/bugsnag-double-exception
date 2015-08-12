# bugsnag-double-exception
Minimal ASP.NET MVC project reproduces Bugsnag issue with doubling exceptions

# Steps to reproduce

1. Build the project.
2. Go to "/".
3. Yellow error page will be displayed.
4. Open "C:\logs\double-exception.log".

In the log file will be two exceptions but should be only one -- the last.

    =============
    
    System.NotImplementedException: The method or operation is not implemented.
       at DoubleException.HomeController.Exception() in C:\Users\t_kirill\workplace\bugsnag\double-exception\reproduce\DoubleException\DoubleException\HomeController.cs:line 17
       at lambda_method(Closure , ControllerBase , Object[] )
       at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
       at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<BeginInvokeSynchronousActionMethod>b__39(IAsyncResult asyncResult, ActionInvocation innerInvokeState)
       at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`2.CallEndDelegate(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3d()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<>c__DisplayClass46.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3f()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)
    
    =============
    
    System.Web.HttpException (0x80004005): Error executing child request for handler 'System.Web.Mvc.HttpHandlerUtil+ServerExecuteHttpHandlerAsyncWrapper'. ---> System.NotImplementedException: The method or operation is not implemented.
       at DoubleException.HomeController.Exception() in C:\Users\t_kirill\workplace\bugsnag\double-exception\reproduce\DoubleException\DoubleException\HomeController.cs:line 17
       at lambda_method(Closure , ControllerBase , Object[] )
       at System.Web.Mvc.ReflectedActionDescriptor.Execute(ControllerContext controllerContext, IDictionary`2 parameters)
       at System.Web.Mvc.ControllerActionInvoker.InvokeActionMethod(ControllerContext controllerContext, ActionDescriptor actionDescriptor, IDictionary`2 parameters)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<BeginInvokeSynchronousActionMethod>b__39(IAsyncResult asyncResult, ActionInvocation innerInvokeState)
       at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncResult`2.CallEndDelegate(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethod(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3d()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.AsyncInvocationWithFilters.<>c__DisplayClass46.<InvokeActionMethodFilterAsynchronouslyRecursive>b__3f()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeActionMethodWithFilters(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<>c__DisplayClass2b.<BeginInvokeAction>b__1c()
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.EndInvokeAction(IAsyncResult asyncResult)
       at System.Web.Mvc.Controller.<BeginExecuteCore>b__1d(IAsyncResult asyncResult, ExecuteCoreState innerState)
       at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncVoid`1.CallEndDelegate(IAsyncResult asyncResult)
       at System.Web.Mvc.Controller.EndExecuteCore(IAsyncResult asyncResult)
       at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncVoid`1.CallEndDelegate(IAsyncResult asyncResult)
       at System.Web.Mvc.Controller.EndExecute(IAsyncResult asyncResult)
       at System.Web.Mvc.MvcHandler.<BeginProcessRequest>b__5(IAsyncResult asyncResult, ProcessRequestState innerState)
       at System.Web.Mvc.Async.AsyncResultWrapper.WrappedAsyncVoid`1.CallEndDelegate(IAsyncResult asyncResult)
       at System.Web.Mvc.MvcHandler.EndProcessRequest(IAsyncResult asyncResult)
       at System.Web.Mvc.HttpHandlerUtil.ServerExecuteHttpHandlerWrapper.<>c__DisplayClass4.<Wrap>b__3()
       at System.Web.Mvc.HttpHandlerUtil.ServerExecuteHttpHandlerWrapper.Wrap[TResult](Func`1 func)
       at System.Web.HttpServerUtility.ExecuteInternal(IHttpHandler handler, TextWriter writer, Boolean preserveForm, Boolean setPreviousPage, VirtualPath path, VirtualPath filePath, String physPath, Exception error, String queryStringOverride)
       at System.Web.HttpServerUtility.ExecuteInternal(IHttpHandler handler, TextWriter writer, Boolean preserveForm, Boolean setPreviousPage, VirtualPath path, VirtualPath filePath, String physPath, Exception error, String queryStringOverride)
       at System.Web.HttpServerUtility.Execute(IHttpHandler handler, TextWriter writer, Boolean preserveForm, Boolean setPreviousPage)
       at System.Web.HttpServerUtility.Execute(IHttpHandler handler, TextWriter writer, Boolean preserveForm)
       at System.Web.Mvc.Html.ChildActionExtensions.ActionHelper(HtmlHelper htmlHelper, String actionName, String controllerName, RouteValueDictionary routeValues, TextWriter textWriter)
       at System.Web.Mvc.Html.ChildActionExtensions.Action(HtmlHelper htmlHelper, String actionName, String controllerName, RouteValueDictionary routeValues)
       at ASP._Page_Views_Home_Index_cshtml.Execute() in c:\Users\t_kirill\workplace\bugsnag\double-exception\reproduce\doubleexception\doubleexception\Views\Home\Index.cshtml:line 13
       at System.Web.WebPages.WebPageBase.ExecutePageHierarchy()
       at System.Web.Mvc.WebViewPage.ExecutePageHierarchy()
       at System.Web.WebPages.WebPageBase.ExecutePageHierarchy(WebPageContext pageContext, TextWriter writer, WebPageRenderingBase startPage)
       at System.Web.Mvc.ViewResultBase.ExecuteResult(ControllerContext context)
       at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
       at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultFilterRecursive(IList`1 filters, Int32 filterIndex, ResultExecutingContext preContext, ControllerContext controllerContext, ActionResult actionResult)
       at System.Web.Mvc.ControllerActionInvoker.InvokeActionResultWithFilters(ControllerContext controllerContext, IList`1 filters, ActionResult actionResult)
       at System.Web.Mvc.Async.AsyncControllerActionInvoker.<>c__DisplayClass21.<BeginInvokeAction>b__1e(IAsyncResult asyncResult)
