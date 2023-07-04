import { Grid,TextField,Button, Typography, Divider } from "@mui/material";
import styled from "@emotion/styled/macro";


const Login = ()=>{
  return(
    <Grid
    container
    height={"100vh"}
    width={"100%"}
    >
      <Grid
        item
        sx={{
          backgroundColor:"black",
          width:"40%",
          height:"100%"
      }}>
      </Grid>

      <Grid
        item
        container
        display={"flex"}
        alignItems={"center"}
        width={"50%"}
      >
        <Grid
          item
          container
          alignItems={"center"}
          flexDirection={"column"}
        >
          <Typography
            fontSize={"32px"}
            variant="h1">
              Bem-Vindo
          </Typography>
          <Typography
            fontSize={"22px"}
            variant="subtitle1"
            marginBottom={"64px"}
          >
            Entre e aproveite as ofertas
          </Typography>
          <form style={{width:"100%"}}>
            <Grid
              container
              justifyContent={"center"}
              paddingBottom={"20px"}
              width={"100%"}
            item>
              <TextField
                variant="outlined"
                label="Email"
                sx={{
                    minWidth:"70%",
                }}
            id="email"/>
            </Grid>
            <Grid
            container
            justifyContent={"center"}
            item>
                <TextField
                  variant="outlined"
                  type="password"
                  label="Senha"
                  sx={{
                    minWidth:"70%"
                  }}
                id="password"/>
            </Grid>
            <Button
            variant="contained"
              sx={{
                display:"block",
                width:"70%",
                marginLeft:"15%",
                marginTop:"10px"
              }}>
                  Entrar
                </Button>
          </form>
        </Grid>
      </Grid>
    </Grid>
  )
}

export default Login