IMG_NAME = core_graph_img
CTN_NAME = core_graph_ctn

.PHONY : container build_img compose prune clean_all

container: build compose

build: help-docker
	@docker-compose build

compose: help-docker
	@docker-compose up 

build_img: help-docker
	@docker build -t $"(IMG_NAME)" . 

prune: help-docker
	@docker image prune

clean_ctn:
	@docker container rm $(docker container ls -aq) -f
  
clean_img:  
	@docker rmi -f $(docker images -q)

clean_all: clean_ctn clean_img

define HELP_TEXT

                  ##         	   
                  ## ## ##        ==
               ## ## ## ## ##    ===
           /"""""""""""""""""___/ ===
          {                       /  ===-
           ______ O           __/
                          __/
              ___________/

Usage:  make prune	
		make build 
		make run 
		make clean_all

endef
export HELP_TEXT

help-docker: ## This help target
	@echo "$$HELP_TEXT"