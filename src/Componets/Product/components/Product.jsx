import React from 'react';
import PropTypes from 'prop-types';
import  { Box, Typography } from '@material-ui/core'
Product.propTypes = {
    product:PropTypes.object,
};

function Product({product}) {
    return (
        <Box padding={3}>
           <Box>
                <img
                src={product.ImageURL}
                alt=''
                height='200px'
            />
           </Box>
           <Box sx={{display:'flex',justifyContent:'center'}}>

                <Typography variant='body2' >{product.name}</Typography>
                <Typography variant='body2'>
                    <Box component="span" fontSize="16px" fontWeight="bold" mr={1}>
                    {new Intl.NumberFormat('vi-VN', {style:'currency', currency:'VND'}).format(product.Price)}
                    </Box>
                    {product.Quantity >0 ? `-${product.Quantity}%` : ''}
                </Typography>
           </Box>
        </Box>
    );
}

export default Product;