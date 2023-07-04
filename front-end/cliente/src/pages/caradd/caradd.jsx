import { Card, CardActionArea, CardContent, CardMedia, Grid, List, ListItem, ListItemButton, ListItemIcon, ListItemText, Paper, Typography } from "@mui/material";
import StarBorderIcon from '@mui/icons-material/StarBorder';
import StarIcon from '@mui/icons-material/Star';
import StarHalfIcon from '@mui/icons-material/StarHalf';
import CheckCircleIcon from '@mui/icons-material/CheckCircle';
import { Link,useNavigate } from "react-router-dom";
import EastIcon from '@mui/icons-material/East';

const CarAdd = () => {
  const navigate = useNavigate();


  return (
    <>
      <Grid justifyContent={"center"} alignItems={"center"} gap={"5%"} container>
        <Grid item xs={5}>
          <Paper sx={{alignItems:"center", justifyContent:"center", display:"flex", padding:"20px"}} elevation={1}>
            <img src="https://picsum.photos/200/300" height={"200px"} alt="Imagem" />
            <List>
              <ListItem>
               <ListItemIcon sx={{minWidth: "33px"}} >
                  <CheckCircleIcon/>
               </ListItemIcon>
               <ListItemText>
                  <Typography fontSize={"1.5rem"}> Adicionado ao carrinho</Typography>
               </ListItemText>
              </ListItem>
              <ListItem>
                <ListItemText>
                  <Typography > Marca: Marca xxx</Typography>
                </ListItemText>
              </ListItem>
              <ListItem>
                <ListItemText>
                  <Typography > Modelo: Modelo xxx</Typography>
                </ListItemText>
              </ListItem>
            </List>
          </Paper>
        </Grid>
        <Grid item xs={5}>
          <Paper sx={{alignItems:"center", justifyContent:"center", display:"flex", padding:"20px"}} elevation={1}>
            <List>
              <ListItem disablePadding>
                <ListItemText>
                <Typography fontWeight={"bold"} fontSize={"1.5rem"}> 
                    Subtotal do carrinho:
                  </Typography>
                </ListItemText>
              </ListItem>
              <ListItem disablePadding>
                <ListItemText>
                  <Typography variant="h5" fontWeight={"bold"}>
                    R$ 100,00
                  </Typography>
                </ListItemText>
              </ListItem>
              <ListItem disablePadding>
              <ListItemButton 
              sx={{
                marginTop:"16px",
                backgroundColor:"#FFD814",
                borderRadius:"5px",
                justifyContent:"center",
                ":hover":{
                  backgroundColor:"#dbb90d"
                }
              }}>
                  Fechar pedido (3 produtos)
                </ListItemButton>
              </ListItem>
              <ListItem disablePadding>
                <ListItemButton
                sx={{
                  border:"1px solid #E9ECEC",
                  borderRadius:"5px",
                  marginTop:"10px",
                  justifyContent:"center",
                }}
                onClick={() => navigate("/shoppingcar")}
                >
                  Ir para o carrinho
                </ListItemButton>
              </ListItem>
            </List>
          </Paper>
        </Grid>

        <Grid
          container
          width={"90%"}
          justifyContent={"center"}
          margin={"36px"}
          gap={"60px"}
          item
        >
          <Card sx={{ maxWidth: "16%" }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  Lizard
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  Lizards are a widespread group of squamate reptiles, with over 6,000
                  species.
                </Typography>
                <Typography variant="h5" component={"div"}>
                  29,90 R$
                </Typography>
                <List>
                  <ListItem disablePadding>
                    <ListItemIcon>
                      <StarIcon/>
                      <StarIcon/>
                      <StarIcon/>
                      <StarHalfIcon/>
                      <StarBorderIcon/>
                    </ListItemIcon>
                  </ListItem>
                </List>
              </CardContent>
            </CardActionArea>
          </Card>
          <Card sx={{ maxWidth:  "16%" }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  Lizard
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  Lizards are a widespread group of squamate reptiles, with over 6,000
                  species, ranging across all continents except Antarctica
                </Typography>
              </CardContent>
            </CardActionArea>
          </Card>
          <Card sx={{ maxWidth:  "16%" }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  Lizard
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  Lizards are a widespread group of squamate reptiles, with over 6,000
                  species, ranging across all continents except Antarctica
                </Typography>
              </CardContent>
            </CardActionArea>
          </Card>
          <Card sx={{ maxWidth:  "16%" }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  Lizard
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  Lizards are a widespread group of squamate reptiles, with over 6,000
                  species, ranging across all continents except Antarctica
                </Typography>
              </CardContent>
            </CardActionArea>
          </Card>
          <Card sx={{ maxWidth:  "16%" }}>
            <CardActionArea>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                  Lizard
                </Typography>
                <Typography variant="body2" color="text.secondary">
                  Lizards are a widespread group of squamate reptiles, with over 6,000
                  species, ranging across all continents except Antarctica
                </Typography>
              </CardContent>
            </CardActionArea>
          </Card>
        </Grid>
      </Grid>
      <Grid container>
      <Link
         style={{
          marginLeft: "5rem",
          textDecoration: "none",
          fontSize: "20px",
          color:"#21738D",
          alignItems: "center",
          ":active": {
            color: "#21738D",
          },
        }} 
         to="/">
          <List>
            <ListItem disablePadding>
              <ListItemText primary="Veja mais produtos" />
              <ListItemIcon>
                <EastIcon sx={{color:"21738D"}} />
              </ListItemIcon>
            </ListItem>
          </List>
          </Link>
      </Grid>
    </>
  );
};

export default CarAdd;
