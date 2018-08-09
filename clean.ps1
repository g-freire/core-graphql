function Clean{
    docker container rm $(docker container ls -aq) -f
    docker rmi -f $(docker images -q)
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

Clean