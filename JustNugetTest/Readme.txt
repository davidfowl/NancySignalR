
-- this test
install-package owin.autostartup.systemweb -pre
install-package nancy.hosting.owin -pre
reference nancy.hosting.owin.shim
add class MainModule : NancyModule

-- proposed goal
install-package nancy.autostartup.systemweb

-- proposed nancy.autostartup.systemweb dependency graph
-nancy.autostartup.systemweb [metapackage]
  -nancy.hosting.owin
    -nancy
    -owin
  -owin.autostartup.systemweb
    -owin.autostartup.sources
    -microsoft.owin.host.systemweb
      -owin

-nancy.autostartup.httplistener [metapackage]
  -nancy.hosting.owin
    -nancy
    -owin
  -owin.autostartup.httplistener
    -owin.autostartup.sources
    -microsoft.owin.host.httplistener
    -microsoft.owin.hosting
      -owin
