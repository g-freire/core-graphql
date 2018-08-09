function Build_Run{
     docker build -t core_graph_img .
     docker run -d -p 3000:80 --name core_graph_ctn core_graph_img
     };

echo('');
Write-Host @"
                  ##         	   
                  ## ## ##        ==
               ## ## ## ## ##    ===
           /"""""""""""""""""___/ ===
          {                       /  ===-
           ______ O           __/
                          __/
              ___________/
                                        
Usage:  ./run.ps1      - build and run img && ctn
        ./clean.ps1    - clean all img && ctn
"@
echo('');

Build_Run