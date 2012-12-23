
-- this test
install-package owin.autostartup.systemweb -pre
install-package nancy.hosting.owin -pre
reference nancy.hosting.owin.shim
add class MainModule : NancyModule

-- proposed goal
install-package nancy.hosting.aspnet
add class MainModule : NancyModule

-- proposed nancy.autostartup.systemweb dependency graph
-nancy.hosting.aspnet [metapackage]
  -nancy.hosting.owin
    -nancy
    -owin
  -owin.autostartup.systemweb
    -owin.autostartup
      -owin
    -microsoft.owin.host.systemweb
      -microsoft.web.infrastructure
      -owin

-nancy.hosting.httplistener [metapackage]
  -nancy.hosting.owin
    -nancy
    -owin
  -owin.autostartup.httplistener
    -owin.autostartup
      -owin
    -microsoft.owin.host.httplistener
    -microsoft.owin.hosting
      -owin
