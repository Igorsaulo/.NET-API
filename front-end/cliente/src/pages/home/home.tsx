import { Grid, List, ListItem, ListItemIcon, Typography } from "@mui/material";
import CategoriaCaroussel from "../../components/categoria/categoriacaroussel"
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import { Button, CardActionArea, CardActions } from '@mui/material';
import StarBorderIcon from '@mui/icons-material/StarBorder';
import StarIcon from '@mui/icons-material/Star';
import StarHalfIcon from '@mui/icons-material/StarHalf';
import { useNavigate } from "react-router-dom";

const Home = () => {
  const navigate = useNavigate();


  return (
    <>
    <CategoriaCaroussel />
    <Grid 
    sx={{marginTop:"32px"}}
    container>
      <Grid
        container
        width={"100%"}
        justifyContent={"center"}
        marginBottom={"32px"}
      item >
        <Typography variant="h2">Mais Vendidos</Typography>
      </Grid>
      <Grid
        container
        width={"100%"}
        justifyContent={"center"}
      item>
        <Grid
          container
          width={"90%"}
          justifyContent={"start"}
          gap={"50px"}
          item
        >
          <Card sx={{ maxWidth: "16%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
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
    </Grid>
    <Grid container>
      <Grid
      marginBottom={"32px"}
      marginTop={"32px"}
        container
        width={"100%"}
        justifyContent={"center"} 
      item >
        <Typography variant="h2">Todos</Typography>
      </Grid>
      <Grid
        container
        width={"100%"}
        justifyContent={"center"}
      item>
        <Grid
          container
          width={"90%"}
          justifyContent={"start"}
          gap={"50px"}
          item
        >
          <Card sx={{ maxWidth: "22%" }}>
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
          <Card sx={{ maxWidth:  "22%" }}>
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
          <Card sx={{ maxWidth:  "22%" }}>
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
          <Card sx={{ maxWidth:  "22%" }}>
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
          <Card sx={{ maxWidth:  "22%" }}>
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
          <Card sx={{ maxWidth:  "22%" }}>
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
    </Grid>
    </>
  )
}

export default Home;