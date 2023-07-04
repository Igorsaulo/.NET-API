import { Button, Grid, Typography } from "@mui/material";
import SearchIcon from '@mui/icons-material/Search';
import ShoppingCartIcon from '@mui/icons-material/ShoppingCart';
import React from "react";
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";


const Navbar = () => {
  const navigate = useNavigate();


  return(
    <Grid 
    width={"100%"} 
    container
    flexDirection={"row"}
    alignItems={"space-between"}
    paddingBottom={"16px"}
    paddingTop={"16px"}
    alignContent={"center"}
    >
      <Grid alignItems={"center"} container justifyContent={"center"} item xs={3} >
        <Link 
        style={{
          textDecoration: "none",
          color: "rgb(24, 24, 24)",
        }} 
        to="/"
        >
        <Typography>Compre compre compre</Typography>
        </Link>
      </Grid>
      <Grid alignItems={"center"} container justifyContent={"center"} item xs={6} >
      <input
        style={{
          paddingTop: "8px",
          paddingBottom: "8px",
          paddingLeft: "4px",
          paddingRight: "4px",
          width: "70%",
        }}
        type="text"
        placeholder="Pesquisar em Compre compre"
      />
      <Button
      sx={{
        borderRadius: "0px",
        backgroundColor: "rgb(24, 24, 24)",
        ":hover": {
          backgroundColor: "black",
        }
      }}
       variant="contained">
        <SearchIcon />
       </Button>
      </Grid>
      <Grid alignItems={"center"} container justifyContent={"space-between"} item xs={3} >
      <Link 
        style={{
          textDecoration: "none",
          color: "rgb(24, 24, 24)",
        }} 
        to="/login"
        >
        <Typography>Cadastrar</Typography>
        </Link>
      <Link 
        style={{
          textDecoration: "none",
          color: "rgb(24, 24, 24)",
        }} 
        to="/login"
        >
        <Typography>Entrar</Typography>
        </Link>
        <Link 
        style={{
          textDecoration: "none",
          color: "rgb(24, 24, 24)",
          marginRight: "16px",
        }} 
        to="/shoppingcar"
        >
        <ShoppingCartIcon />
        </Link>
      </Grid>
    </Grid>
  )
}

export default Navbar;