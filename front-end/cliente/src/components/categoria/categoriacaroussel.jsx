import { Carousel } from '@trendyol-js/react-carousel';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { Button, CardActionArea, CardActions } from '@mui/material';


const categorias = [
  {
    nome: "Games",
    imagem:"https://images.kabum.com.br/produtos/fotos/238670/console-sony-playstation-5-edicao-digital_1634132113_gg.jpg"
  },
  {
    nome:"Tvs",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/un75cu7700gxzd/gallery/br-uhd-4k-tv-un75cu7700gxzd-front-black-536081682?$1300_1038_PNG$"
  },
  {
    nome:"Smartphones",
    imagem:"https://samsungbrshop.vtexassets.com/arquivos/ids/200596-800-auto?v=638048057328700000&width=800&height=auto&aspect=true"
  },
  {
    nome:"Notebooks",
    imagem:"https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/mbp16-spacegray-select-202301?wid=2000&hei=1222&fmt=jpeg&qlt=95&.v=1671304673202"
  },
  {
    nome:"Acessórios",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/ep-p1300tbegbr/gallery/br-wireless-charger-ep-p1300tbegbr-frontblack-368271271?$160_160_PNG$"
  },
  {
    nome:"Eletrodomésticos",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/rf28r6201sr/gallery/br-rf28r6201sr-frontsilver-368271271?$160_160_PNG$"
  },
  {
    nome:"Moda",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/sm-r175nzkazto/gallery/br-galaxy-buds-plus-sm-r175nzkazto-frontblack-368271271?$160_160_PNG$"
  },
  {
    nome:"Brinquedos",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/np950sbe-xd1br/gallery/br-notebook-9-pro-np950sbe-xd1br-xxz-frontblack-368271271?$160_160_PNG$"
  },
  {
    nome:"Livros",
    imagem:"https://images.samsung.com/is/image/samsung/p6pim/br/np950sbe-xd1br/gallery/br-notebook-9-pro-np950sbe-xd1br-xxz-frontblack-368271271?$160_160_PNG$"
  }
]


export const CategoriaCaroussel = () => {
  return (
    <Carousel show={3.5} slide={2} transition={0.5} swiping={true} >
      {categorias.map((categoria) => (
        <Card sx={{ maxWidth: 345, margin: "16px", height:"260px" }}>
          <CardActionArea>
            <CardMedia
              component="img"
              height="200"
              image={categoria.imagem}
              alt={categoria.nome}
            />
            <CardContent>
              <Typography gutterBottom variant="h5" component="div">
                {categoria.nome}
              </Typography>
            </CardContent>
          </CardActionArea>
        </Card>
      ))}
    </Carousel>
  )
}


export default CategoriaCaroussel;