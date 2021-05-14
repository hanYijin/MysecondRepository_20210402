install.packages("devtools")
library(devtools)
#install_github('dkahle/ggmap')
library('ggmap')
apikey= 'AIzaSyD2gUodnZWtOt7jEimuwuHyHQ2g9SgbXOE'
register_google(apikey)
ggDaegu <- get_googlemap('daegu', maptype = 'hybrid')
ggmap(ggDaegu)
