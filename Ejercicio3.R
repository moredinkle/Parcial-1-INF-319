Moda <- function(x) {
  unicos <- unique(x) 
  
  
  if (length(x)==length(unicos)) {
    mode_x <- 'No hay moda'
    return(mode_x)
  } 
  
  repe <- rep(0, length(unicos))
  
  for (i in 1:length(unicos)) {
    for (j in 1:length(x)) {
      if (unicos[i]==x[j]) {
        repe[i] = repe[i] + 1;
      }
    }
  }
  
  if (mean(repe)==max(repe)) {
    mode_x <- 'No hay moda'
    return(mode_x)
  }
  
  idx <- which.max(repe)
  mode_x <- unicos[idx]
  return(mode_x)
}


library("modeest")
lista = sample(1:8,15, replace=T)
print(lista)

mlv(lista, method="mfv")
Moda(lista)
