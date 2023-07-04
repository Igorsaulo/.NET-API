import { Divider, FormControl, Grid, List, ListItem, ListItemButton, ListItemIcon, ListItemText, MenuItem, Select, Typography } from "@mui/material";
import StarBorderIcon from '@mui/icons-material/StarBorder';
import StarIcon from '@mui/icons-material/Star';
import StarHalfIcon from '@mui/icons-material/StarHalf';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import { Button, CardActionArea, CardActions } from '@mui/material';
import { Link } from "react-router-dom";
import EastIcon from '@mui/icons-material/East';
import { useNavigate } from "react-router-dom";


const ProdutoPage = () => {
  const navigate = useNavigate();


  return (
    <>
       <Grid container>
      <Grid height={"91vh"} item container xs={6}>
        <Grid marginLeft={"2%"} marginTop={"10%"} height={"70%"} bgcolor={"black"} width={"100%"} item xs={1}>
          <Typography>t</Typography>
        </Grid>
        <Grid j
        justifyContent={"center"}
        marginLeft={"2%"} 
        container 
        width={"100%"} 
        height={"100%"} 
        bgcolor={"grey"}
        alignItems={"center"}
        item xs={10}>
          <Typography>Produto</Typography>
        </Grid>
      </Grid>
      <Grid item container xs={3}>
        <List>
            <ListItem disablePadding>
              <Typography variant={"h5"}>Produto

Produto Notebook Lenovo IdeaPad 3i Celeron 4GB 128GB SSD + Microsoft 365 Personal - Windows 11 15.6' 82BU0008BR Prata</Typography>
            </ListItem>
            <ListItem disablePadding>
              <ListItemIcon sx={{paddingBottom:"10px"}}>
                <StarIcon/>
                <StarIcon/>
                <StarIcon/>
                <StarHalfIcon/>
                <StarBorderIcon/>
                </ListItemIcon>
            </ListItem>
            <Divider/>
            <ListItem sx={{marginTop:"32px"}} >
              <Typography variant={"h5"}>R$ 2.699,00</Typography>
            </ListItem>
            <ListItem>
            <Typography sx={{fontSize:"12px"}} >de: R$ <span style={{textDecoration:"line-through"}}>3.500,95</span> </Typography>
            </ListItem>
            <ListItem>
            <Typography sx={{fontSize:"12px"}} >10x de R$ 269,90 sem juros</Typography>
            </ListItem>
            <Divider sx={{marginTop:"10px",marginBottom:"32px"}}/>
            <ListItem>
              <Typography fontWeight={"bold"}>Marca:</Typography>
              <Typography marginLeft={"10px"}>Lenovo</Typography>
            </ListItem>
            <ListItem>
              <Typography fontWeight={"bold"}>Processador:</Typography>
              <Typography marginLeft={"10px"}>Intel core 11</Typography>
            </ListItem>
            <ListItem>
              <Typography fontWeight={"bold"}>RAM:</Typography>
              <Typography marginLeft={"10px"}>8 GB</Typography>
            </ListItem>
            <ListItem>
              <Typography fontWeight={"bold"}>Armazenamento:</Typography>
              <Typography marginLeft={"10px"}>250 GB</Typography>
            </ListItem>
            <ListItem>
              <Typography fontWeight={"bold"}>Tipo de Armazenamento:</Typography>
              <Typography marginLeft={"10px"}>SSD</Typography>
            </ListItem>
            <Divider sx={{marginTop:"10px",marginBottom:"32px"}}/>
            <ListItem>
              <Typography fontWeight={"bold"}>Descrição:</Typography>
            </ListItem>
            <ListItem>
            <Typography>Notebook Lenovo IdeaPad 3i Celeron 4GB 128GB SSD + Microsoft 365 Personal - Windows 11 15.6' 82BU0008BR Prata</Typography>
            </ListItem>
        </List>
      </Grid>
      <Grid justifyContent={"center"} xs={2.8} marginRight={"10px"} borderRadius={"5px"} border={"1px solid #a9a9a9"} height={"100%"}  item container>
        <List>
          <ListItem>
            <Typography variant={"h5"}>R$ 2.699,00</Typography>
          </ListItem>
          <ListItem>
            <Typography color={"#007185"}>Entrega grátis em:</Typography>
            <Typography marginLeft={"10px"}>11 a 12 de maio</Typography>
          </ListItem>
          <ListItem>
            <Typography variant="h6" color={"#007600"}>Em Estoque</Typography>
          </ListItem>
          <ListItem>
            <Typography>Quantidade:</Typography>
            <FormControl sx={{marginLeft:"10px"}} variant="standard">
            <Select>
              <MenuItem value={1}>1</MenuItem>
            </Select>
            </FormControl>
          </ListItem>
          <ListItem>
            <ListItemButton 
            sx={{
              backgroundColor:"#FFD814",
              borderRadius:"5px",
              justifyContent:"center",
              ":hover":{
                backgroundColor:"#dbb90d"
              }
              }}>
              <Typography>Comprar agora</Typography>
            </ListItemButton>
          </ListItem>
          <ListItem>
            <ListItemButton 
            sx={{
              backgroundColor:"#FFA41C",
              borderRadius:"5px",
              justifyContent:"center",
              ":hover":{
                backgroundColor:"#dd8d15"
              }
              }}
              onClick={() => navigate("/caradd")}
              >
              <Typography>Adcionar ao Carrinho</Typography>
            </ListItemButton>
          </ListItem>
        </List>
      </Grid>
   </Grid>
   <Grid container>
    <Grid item xs={5}>
      <Typography variant="h5" marginBottom={"16px"} marginLeft={"2%"}>Ficha Tecnica</Typography>
      <TableContainer sx={{marginLeft: "4%"}}>
      <Table sx={{border:"1px solid #E0E0E0"}} stickyHeader aria-label="sticky table">
        <TableHead>
          <TableRow>
            <TableCell sx={{backgroundColor: "#f3f3f3",width:"50%"}}>
              <Typography>Marca</Typography>
            </TableCell>
            <TableCell>
              <Typography>Lenovo</Typography>
            </TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          <TableRow>
            <TableCell>
              <Typography>Processador</Typography>
            </TableCell>
            <TableCell>
              <Typography>Intel core 11</Typography>
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <Typography>RAM</Typography>
            </TableCell>
            <TableCell>
              <Typography>8 GB</Typography>
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <Typography>Armazenamento</Typography>
            </TableCell>
            <TableCell>
              <Typography>250 GB</Typography>
            </TableCell>
          </TableRow>
          <TableRow>
            <TableCell>
              <Typography>Tipo de Armazenamento</Typography>
            </TableCell>
            <TableCell>
              <Typography>SSD</Typography>
            </TableCell>
          </TableRow>
        </TableBody>
      </Table>
    </TableContainer>
    </Grid>
    <Grid item marginLeft={"9%"} xs={5}>
      <Typography variant="h5" marginBottom={"16px"} >Ourtos Produtos</Typography>
      <Grid gap={"5%"} item container>
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
      </Grid>
      <Grid marginTop={"30px"} gap={"5%"} item container>
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
          <Card sx={{ maxWidth: "30%" }}>
            <CardActionArea onClick={() => navigate("produto/1")}>
              <CardMedia
                component="img"
                height="140"
                image="https://picsum.photos/200/300"
                alt="green iguana"
              />
              <CardContent>
                <Typography gutterBottom fontSize={"16px"} component="div">
                  Lizard
                </Typography>
                <Typography fontSize={"20px"} component={"div"}>
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
         <Link
         style={{
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
    </Grid>
   </Grid>
    </>
  )
};

export default ProdutoPage;