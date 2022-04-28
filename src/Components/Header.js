import * as React from 'react';
import { styled, alpha } from '@mui/material/styles';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Toolbar from '@mui/material/Toolbar';
import IconButton from '@mui/material/IconButton';
import Typography from '@mui/material/Typography';
import InputBase from '@mui/material/InputBase';
import { Badge } from '@mui/material';
import SearchIcon from '@mui/icons-material/Search';
import { AccountCircle } from '@mui/icons-material';
import { Button } from '@mui/material';
import { Avatar } from '@mui/material';
import { Grid } from '@mui/material';
import ShoppingCartSharpIcon from '@mui/icons-material/ShoppingCartSharp';
import ArrowForwardIosIcon from '@mui/icons-material/ArrowForwardIos';
import { Link } from 'react-router-dom';




const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: alpha(theme.palette.common.white, 0.15),
  '&:hover': {
    backgroundColor: alpha(theme.palette.common.white, 0.25),
  },
  
  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(1),
    width: 'auto',
  },
}));

const SearchIconWrapper = styled('div')(({ theme }) => ({
  padding: theme.spacing(0, 2),
  height: '100%',
  position: 'absolute',
  pointerEvents: 'none',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
}));

const SearchFloat = styled('div')(({theme})=>({
   paddingRight : theme.spacing(2),
   height:'50%'
   
}))

const StyledInputBase = styled(InputBase)(({ theme }) => ({
    color: 'inherit',
    '& .MuiInputBase-input': {
      padding: theme.spacing(1, 1, 1, 0),
      // vertical padding + font size from searchIcon
      paddingLeft: `calc(1em + ${theme.spacing(4)})`,
      transition: theme.transitions.create('width'),
      width: '100%',
      [theme.breakpoints.up('sm')]: {
        width: '70ch',
        '&:focus': {
          width: '75ch',
        },
      },
    },
  }));

 
  
export default function Header() {
   
  

  return (
    <Box sx={{ flexGrow: 1 }}>
      <AppBar position="static">
        <Toolbar>
          <IconButton
            size="large"
            edge="start"
            color="inherit"
            aria-label="open drawer"
            sx={{ mr: 2 }}
          >
            <Avatar
             sx={{width:110, height:28,bgcolor:'#ffffff'}}
             variant= "rounded"
             src='https://upload.wikimedia.org/wikipedia/commons/6/64/Logo_Tiki.png' ></Avatar>
          </IconButton>
          <Box sx={{pl:25}}>
            <Search
              sx={{flexGrow:0.8, display: { xs: 'none', sm: 'block' }}}
            >
              <SearchIconWrapper>
                  <SearchFloat> <SearchIcon /></SearchFloat>
              </SearchIconWrapper>
              <StyledInputBase
                placeholder="Tìm kiếm sản phẩm…"
                inputProps={{ 'aria-label': 'search' }}
              />
            </Search>
          </Box>
          <Box sx={{flexGrow :0.5}} />
          <Box sx={{display : {xs :'none', md :'flex'}}}>
            <IconButton
              size="large"
              edge="end"
              aria-label='account of current user'
              color="inherit"
            >
              <AccountCircle/>
            </IconButton>
            <Button
              variant='text'
              color='inherit'>
            
              <Link className='link' underline="none" to='/login'>
                Dang nhap
              </Link>
            </Button>
            <Button
              variant='text'
              color='inherit'
            >
              Đăng kí
            </Button>
            <IconButton
              size='large'
              edge='end'
              color='inherit'
            >
              <Badge><ShoppingCartSharpIcon/></Badge>
            </IconButton>
            <Typography
              variant='inherit'
              align='justify'
              sx={{lineHeight: '5'}}
              >Giỏ hàng
            </Typography>
          </Box>
        </Toolbar>
      </AppBar>
      <Box>

      <Grid container spacing={1.6} columns={16} sx={{pl:5, mt:0.1}}>
        <Grid item xs={0.8}>
          <Typography>Điện tử</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Thiết bị số</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Điện thoại</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Mẹ & bé</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Làm đẹp</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Gia dụng</Typography>
        </Grid>
        <Grid item xs={1.3}>
          <Typography>Thời trang nữ</Typography>
        </Grid>
        <Grid item xs={1.4}>
          <Typography>Thời trang nam</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Giày nữ</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Túi nữ</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Balo & vali</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Phụ kiện</Typography>
        </Grid>
        <Grid item xs={1}>
          <Typography>Đồng hồ</Typography>
        </Grid>
        <Grid item xs={0.5}>
          <Typography>Xe</Typography>
        </Grid>
        <Grid item xs={1}>
        <IconButton
              sx={{mt:-1}}
              edge='end'
              color='inherit'
            >
              <Badge><ArrowForwardIosIcon/></Badge>
            </IconButton>
        </Grid>
       
      </Grid>
      </Box>

     
      </Box>

    
    
  );
}
