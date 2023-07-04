import { Box, Grid, List, ListItem, ListItemButton, ListItemText, Paper, Typography } from "@mui/material";

const Shoppingcar = () => {
  return (
    <Grid justifyContent={"center"} container>
      <Grid item xs={10}>
        <Paper 
        elevation={3} 
        sx={{
          width:"100%",
          padding:"20px",
          alignItems:"center",
          display:"flex",
          flexDirection:"column",
          minHeight:"40vh"
        }}
          >
          <Box sx={{width:"100%"}}>
            <Typography color={"black"} variant="h5">Carrinho de compras</Typography>
          </Box>
          <Box width={"100%"} bgcolor={"#E0E0E0"} height={"1px"}></Box>
          <Grid alignItems={"center"} item container>
            <Grid item xs={2}>
              <Box sx={{width:"80%",height:"10rem",backgroundColor:"black"}}></Box>
            </Grid>
            <List>
              <ListItem sx={{display:"flex",flexDirection:"column",alignItems:"start"}}>
                <ListItemText
                primaryTypographyProps={{variant:"h6"}} 
                primary="Nome do produto" 
                secondary="Em até 12x sem juros" 
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    fontWeight:"bold"
                  }
                }}
                secondary="R$ 1.000,00"
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    color:"green"
                  }
                }}
                secondary="Em estoque"
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    color:"green"
                  }
                }}
                secondary="Frete grátis"
                />
                <ListItem disablePadding>
                <ListItemText>
                    <Typography paddingRight={"10px"}>
                      Quantidade
                      <select style={{marginLeft:"10px"}}>
                        <option>0</option>
                        <option>1</option>
                        <option>2</option>
                      </select>
                    </Typography>
                  </ListItemText>
                  <ListItemText
                  sx={{
                    marginLeft: "10px",
                    "&:hover": {
                      cursor: "pointer",
                      color: "red",
                    }
                  }}
                >
                  <Typography>
                    Remover
                  </Typography>
                </ListItemText>
                </ListItem>
              </ListItem>
              <ListItem>
              <ListItemButton 
                sx={{
                  backgroundColor:"#FFD814",
                  borderRadius:"5px",
                  justifyContent:"center",
                  ":hover":{
                    backgroundColor:"#dbb90d",
                  }
                  }}
                >
                  Finalizar compra
                </ListItemButton>
              </ListItem>
            </List>
          </Grid>
          <Box width={"100%"} bgcolor={"#E0E0E0"} height={"1px"}></Box>
          <Grid alignItems={"center"} item container>
            <Grid item xs={2}>
              <Box sx={{width:"80%",height:"10rem",backgroundColor:"black"}}></Box>
            </Grid>
            <List>
              <ListItem sx={{display:"flex",flexDirection:"column",alignItems:"start"}}>
                <ListItemText
                primaryTypographyProps={{variant:"h6"}} 
                primary="Nome do produto" 
                secondary="Em até 12x sem juros" 
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    fontWeight:"bold"
                  }
                }}
                secondary="R$ 1.000,00"
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    color:"green"
                  }
                }}
                secondary="Em estoque"
                />
                <ListItemText
                secondaryTypographyProps={{
                  sx:{
                    color:"green"
                  }
                }}
                secondary="Frete grátis"
                />
                <ListItem disablePadding>
                <ListItemText>
                    <Typography paddingRight={"10px"}>
                      Quantidade
                      <select style={{marginLeft:"10px"}}>
                        <option>0</option>
                        <option>1</option>
                        <option>2</option>
                      </select>
                    </Typography>
                  </ListItemText>
                  <ListItemText
                  sx={{
                    marginLeft: "10px",
                    "&:hover": {
                      cursor: "pointer",
                      color: "red",
                    }
                  }}
                >
                  <Typography>
                    Remover
                  </Typography>
                </ListItemText>
                </ListItem>
              </ListItem>
              <ListItem>
              <ListItemButton 
                sx={{
                  backgroundColor:"#FFD814",
                  borderRadius:"5px",
                  justifyContent:"center",
                  ":hover":{
                    backgroundColor:"#dbb90d",
                  }
                  }}
                >
                  Finalizar compra
                </ListItemButton>
              </ListItem>
            </List>
          </Grid>
          <Box width={"100%"} bgcolor={"#E0E0E0"} height={"1px"}></Box>
          <Grid justifyContent={"end"} item container>
            <Grid item xs={4}>
              <List>
                <ListItem>
                  <ListItemText
                  primaryTypographyProps={{variant:"h6"}}
                  primary="Total:"
                  />
                  <ListItemText
                  primaryTypographyProps={{variant:"h6"}}
                  primary="R$ 2.000,00"
                  />
                              <ListItemButton 
            sx={{
              backgroundColor:"#FFA41C",
              borderRadius:"5px",
              justifyContent:"center",
              ":hover":{
                backgroundColor:"#dd8d15"
              }
              }}
              >
              <Typography>Fechar Pedido</Typography>
            </ListItemButton>
                </ListItem>
              </List>
            </Grid>
          </Grid>
        </Paper>
        </Grid>
    </Grid>
  )
}

export default Shoppingcar;