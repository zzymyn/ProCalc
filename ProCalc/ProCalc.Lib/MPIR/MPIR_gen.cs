﻿using System;
using System.Text;
using System.Runtime.InteropServices;

namespace ProCalc.Lib.MPIR
{
    internal static partial class MPIR
    {
		// Skipped gmp_randinit_default - gmp_randstate_t => void
		// Skipped gmp_randinit_lc_2exp_size - gmp_randstate_t,mp_bitcnt_t => int
		// Skipped gmp_randinit_mt - gmp_randstate_t => void
		// Skipped gmp_randinit_set - gmp_randstate_t,__gmp_const __gmp_randstate_struct * => void
		// Skipped gmp_randseed - gmp_randstate_t,mpz_srcptr => void
		// Skipped gmp_randseed_ui - gmp_randstate_t,mpir_ui => void
		// Skipped gmp_randclear - gmp_randstate_t => void
		// Skipped gmp_urandomb_ui - gmp_randstate_t,mpir_ui => mpir_ui
		// Skipped gmp_urandomm_ui - gmp_randstate_t,mpir_ui => mpir_ui
		// Skipped gmp_obstack_vprintf - struct obstack *,__gmp_const char *,va_list => int
		// Skipped gmp_vasprintf - char **,__gmp_const char *,va_list => int
		// Skipped gmp_vfprintf - FILE *,__gmp_const char *,va_list => int
		// Skipped gmp_vprintf - __gmp_const char *,va_list => int
		// Skipped gmp_vsnprintf - char *,size_t,__gmp_const char *,va_list => int
		// Skipped gmp_vsprintf - char *,__gmp_const char *,va_list => int
		// Skipped gmp_vfscanf - FILE *,__gmp_const char *,va_list => int
		// Skipped gmp_vscanf - __gmp_const char *,va_list => int
		// Skipped gmp_vsscanf - __gmp_const char *,__gmp_const char *,va_list => int
		// Skipped _mpz_realloc - mpz_ptr,mp_size_t => void *
		[DllImport("mpir.dll", EntryPoint = "__gmpz_abs")]
        internal static extern void mpz_abs([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_add")]
        internal static extern void mpz_add([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_add_ui")]
        internal static extern void mpz_add_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_addmul")]
        internal static extern void mpz_addmul([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_addmul_ui")]
        internal static extern void mpz_addmul_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_and")]
        internal static extern void mpz_and([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		// Skipped mpz_array_init - mpz_ptr,mp_size_t,mp_size_t => void
		[DllImport("mpir.dll", EntryPoint = "__gmpz_bin_ui")]
        internal static extern void mpz_bin_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_bin_uiui")]
        internal static extern void mpz_bin_uiui([In, Out] MPZ a0, ulong a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_q")]
        internal static extern void mpz_cdiv_q([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_q_2exp")]
        internal static extern void mpz_cdiv_q_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_q_ui")]
        internal static extern ulong mpz_cdiv_q_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_qr")]
        internal static extern void mpz_cdiv_qr([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, [In] MPZ a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_qr_ui")]
        internal static extern ulong mpz_cdiv_qr_ui([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, ulong a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_r")]
        internal static extern void mpz_cdiv_r([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_r_2exp")]
        internal static extern void mpz_cdiv_r_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_r_ui")]
        internal static extern ulong mpz_cdiv_r_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cdiv_ui")]
        internal static extern ulong mpz_cdiv_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_clear")]
        internal static extern void mpz_clear([In, Out] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_clrbit")]
        internal static extern void mpz_clrbit([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cmp")]
        internal static extern int mpz_cmp([In] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cmp_d")]
        internal static extern int mpz_cmp_d([In] MPZ a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__g_mpz_cmp_si")]
        internal static extern int _mpz_cmp_si([In] MPZ a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__g_mpz_cmp_ui")]
        internal static extern int _mpz_cmp_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cmpabs")]
        internal static extern int mpz_cmpabs([In] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cmpabs_d")]
        internal static extern int mpz_cmpabs_d([In] MPZ a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_cmpabs_ui")]
        internal static extern int mpz_cmpabs_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_com")]
        internal static extern void mpz_com([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_combit")]
        internal static extern void mpz_combit([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_congruent_p")]
        internal static extern int mpz_congruent_p([In] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_congruent_2exp_p")]
        internal static extern int mpz_congruent_2exp_p([In] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_congruent_ui_p")]
        internal static extern int mpz_congruent_ui_p([In] MPZ a0, ulong a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_divexact")]
        internal static extern void mpz_divexact([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_divexact_ui")]
        internal static extern void mpz_divexact_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_divisible_p")]
        internal static extern int mpz_divisible_p([In] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_divisible_ui_p")]
        internal static extern int mpz_divisible_ui_p([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_divisible_2exp_p")]
        internal static extern int mpz_divisible_2exp_p([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_dump")]
        internal static extern void mpz_dump([In] MPZ a0);
		// Skipped mpz_export - void *,size_t *,int,size_t,int,size_t,mpz_srcptr => void *
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fac_ui")]
        internal static extern void mpz_fac_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_2fac_ui")]
        internal static extern void mpz_2fac_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mfac_uiui")]
        internal static extern void mpz_mfac_uiui([In, Out] MPZ a0, ulong a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_primorial_ui")]
        internal static extern void mpz_primorial_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_q")]
        internal static extern void mpz_fdiv_q([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_q_2exp")]
        internal static extern void mpz_fdiv_q_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_q_ui")]
        internal static extern ulong mpz_fdiv_q_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_qr")]
        internal static extern void mpz_fdiv_qr([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, [In] MPZ a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_qr_ui")]
        internal static extern ulong mpz_fdiv_qr_ui([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, ulong a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_r")]
        internal static extern void mpz_fdiv_r([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_r_2exp")]
        internal static extern void mpz_fdiv_r_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_r_ui")]
        internal static extern ulong mpz_fdiv_r_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fdiv_ui")]
        internal static extern ulong mpz_fdiv_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fib_ui")]
        internal static extern void mpz_fib_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fib2_ui")]
        internal static extern void mpz_fib2_ui([In, Out] MPZ a0, [In, Out] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_sint_p")]
        internal static extern int mpz_fits_sint_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_si_p")]
        internal static extern int mpz_fits_si_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_slong_p")]
        internal static extern int mpz_fits_slong_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_sshort_p")]
        internal static extern int mpz_fits_sshort_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_uint_p")]
        internal static extern int mpz_fits_uint_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_ui_p")]
        internal static extern int mpz_fits_ui_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_ulong_p")]
        internal static extern int mpz_fits_ulong_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_fits_ushort_p")]
        internal static extern int mpz_fits_ushort_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_gcd")]
        internal static extern void mpz_gcd([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_gcd_ui")]
        internal static extern ulong mpz_gcd_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_gcdext")]
        internal static extern void mpz_gcdext([In, Out] MPZ a0, [In, Out] MPZ a1, [In, Out] MPZ a2, [In] MPZ a3, [In] MPZ a4);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_get_d")]
        internal static extern double mpz_get_d([In] MPZ a0);
		// Skipped mpz_get_d_2exp - signed long *,mpz_srcptr => double
		[DllImport("mpir.dll", EntryPoint = "__gmpz_get_str")]
        internal static extern /* char* */ IntPtr mpz_get_str([MarshalAs(UnmanagedType.LPStr)] StringBuilder a0, int a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_get_ui")]
        internal static extern ulong mpz_get_ui([In] MPZ a0);
		// Skipped mpz_getlimbn - mpz_srcptr,mp_size_t => mp_limb_t
		// Skipped mpz_hamdist - mpz_srcptr,mpz_srcptr => mp_bitcnt_t
		// Skipped mpz_import - mpz_ptr,size_t,int,size_t,int,size_t,__gmp_const void * => void
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init")]
        internal static extern void mpz_init([In, Out] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init2")]
        internal static extern void mpz_init2([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init_set")]
        internal static extern void mpz_init_set([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init_set_d")]
        internal static extern void mpz_init_set_d([In, Out] MPZ a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init_set_si")]
        internal static extern void mpz_init_set_si([In, Out] MPZ a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init_set_str")]
        internal static extern int mpz_init_set_str([In, Out] MPZ a0, [MarshalAs(UnmanagedType.LPStr)] string a1, int a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_init_set_ui")]
        internal static extern void mpz_init_set_ui([In, Out] MPZ a0, ulong a1);
		// Skipped mpz_inp_raw - mpz_ptr,FILE * => size_t
		// Skipped mpz_inp_str - mpz_ptr,FILE *,int => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpz_invert")]
        internal static extern int mpz_invert([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_ior")]
        internal static extern void mpz_ior([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_jacobi")]
        internal static extern int mpz_jacobi([In] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_kronecker_si")]
        internal static extern int mpz_kronecker_si([In] MPZ a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_kronecker_ui")]
        internal static extern int mpz_kronecker_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_si_kronecker")]
        internal static extern int mpz_si_kronecker(long a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_ui_kronecker")]
        internal static extern int mpz_ui_kronecker(ulong a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_lcm")]
        internal static extern void mpz_lcm([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_lcm_ui")]
        internal static extern void mpz_lcm_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_lucnum_ui")]
        internal static extern void mpz_lucnum_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_lucnum2_ui")]
        internal static extern void mpz_lucnum2_ui([In, Out] MPZ a0, [In, Out] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_millerrabin")]
        internal static extern int mpz_millerrabin([In] MPZ a0, int a1);
		// Skipped mpz_miller_rabin - mpz_srcptr,int,gmp_randstate_t => int
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mod")]
        internal static extern void mpz_mod([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mul")]
        internal static extern void mpz_mul([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mul_2exp")]
        internal static extern void mpz_mul_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mul_si")]
        internal static extern void mpz_mul_si([In, Out] MPZ a0, [In] MPZ a1, long a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_mul_ui")]
        internal static extern void mpz_mul_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_neg")]
        internal static extern void mpz_neg([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_nextprime")]
        internal static extern void mpz_nextprime([In, Out] MPZ a0, [In] MPZ a1);
		// Skipped mpz_next_prime_candidate - mpz_ptr,mpz_srcptr,gmp_randstate_t => void
		// Skipped mpz_out_raw - FILE *,mpz_srcptr => size_t
		// Skipped mpz_out_str - FILE *,int,mpz_srcptr => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpz_perfect_power_p")]
        internal static extern int mpz_perfect_power_p([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_perfect_square_p")]
        internal static extern int mpz_perfect_square_p([In] MPZ a0);
		// Skipped mpz_popcount - mpz_srcptr => mp_bitcnt_t
		[DllImport("mpir.dll", EntryPoint = "__gmpz_pow_ui")]
        internal static extern void mpz_pow_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_powm")]
        internal static extern void mpz_powm([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2, [In] MPZ a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_powm_ui")]
        internal static extern void mpz_powm_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2, [In] MPZ a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_probab_prime_p")]
        internal static extern int mpz_probab_prime_p([In] MPZ a0, int a1);
		// Skipped mpz_probable_prime_p - mpz_srcptr,gmp_randstate_t,int,mpir_ui => int
		// Skipped mpz_likely_prime_p - mpz_srcptr,gmp_randstate_t,mpir_ui => int
		[DllImport("mpir.dll", EntryPoint = "__gmpz_realloc2")]
        internal static extern void mpz_realloc2([In, Out] MPZ a0, ulong a1);
		// Skipped mpz_remove - mpz_ptr,mpz_srcptr,mpz_srcptr => mp_bitcnt_t
		[DllImport("mpir.dll", EntryPoint = "__gmpz_root")]
        internal static extern int mpz_root([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_nthroot")]
        internal static extern void mpz_nthroot([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_rootrem")]
        internal static extern void mpz_rootrem([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, ulong a3);
		// Skipped mpz_rrandomb - mpz_ptr,gmp_randstate_t,mp_bitcnt_t => void
		// Skipped mpz_scan0 - mpz_srcptr,mp_bitcnt_t => mp_bitcnt_t
		// Skipped mpz_scan1 - mpz_srcptr,mp_bitcnt_t => mp_bitcnt_t
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set")]
        internal static extern void mpz_set([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_d")]
        internal static extern void mpz_set_d([In, Out] MPZ a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_f")]
        internal static extern void mpz_set_f([In, Out] MPZ a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_q")]
        internal static extern void mpz_set_q([In, Out] MPZ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_si")]
        internal static extern void mpz_set_si([In, Out] MPZ a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_str")]
        internal static extern int mpz_set_str([In, Out] MPZ a0, [MarshalAs(UnmanagedType.LPStr)] string a1, int a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_set_ui")]
        internal static extern void mpz_set_ui([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_setbit")]
        internal static extern void mpz_setbit([In, Out] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_size")]
        internal static extern ulong mpz_size([In] MPZ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_sizeinbase")]
        internal static extern ulong mpz_sizeinbase([In] MPZ a0, int a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_sqrt")]
        internal static extern void mpz_sqrt([In, Out] MPZ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_sqrtrem")]
        internal static extern void mpz_sqrtrem([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_sub")]
        internal static extern void mpz_sub([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_sub_ui")]
        internal static extern void mpz_sub_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_ui_sub")]
        internal static extern void mpz_ui_sub([In, Out] MPZ a0, ulong a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_submul")]
        internal static extern void mpz_submul([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_submul_ui")]
        internal static extern void mpz_submul_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_swap")]
        internal static extern void mpz_swap([In, Out] MPZ a0, [In, Out] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_ui")]
        internal static extern ulong mpz_tdiv_ui([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_q")]
        internal static extern void mpz_tdiv_q([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_q_2exp")]
        internal static extern void mpz_tdiv_q_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_q_ui")]
        internal static extern ulong mpz_tdiv_q_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_qr")]
        internal static extern void mpz_tdiv_qr([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, [In] MPZ a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_qr_ui")]
        internal static extern ulong mpz_tdiv_qr_ui([In, Out] MPZ a0, [In, Out] MPZ a1, [In] MPZ a2, ulong a3);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_r")]
        internal static extern void mpz_tdiv_r([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_r_2exp")]
        internal static extern void mpz_tdiv_r_2exp([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tdiv_r_ui")]
        internal static extern ulong mpz_tdiv_r_ui([In, Out] MPZ a0, [In] MPZ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_tstbit")]
        internal static extern int mpz_tstbit([In] MPZ a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpz_ui_pow_ui")]
        internal static extern void mpz_ui_pow_ui([In, Out] MPZ a0, ulong a1, ulong a2);
		// Skipped mpz_urandomb - mpz_ptr,gmp_randstate_t,mp_bitcnt_t => void
		// Skipped mpz_urandomm - mpz_ptr,gmp_randstate_t,mpz_srcptr => void
		[DllImport("mpir.dll", EntryPoint = "__gmpz_xor")]
        internal static extern void mpz_xor([In, Out] MPZ a0, [In] MPZ a1, [In] MPZ a2);
		// Skipped mpz_get_ux - mpz_srcptr => uintmax_t
		// Skipped mpz_get_sx - mpz_srcptr => intmax_t
		// Skipped mpz_set_ux - mpz_ptr,uintmax_t => void
		// Skipped mpz_set_sx - mpz_ptr,intmax_t => void
		// Skipped mpz_init_set_ux - mpz_ptr,uintmax_t => void
		// Skipped mpz_init_set_sx - mpz_ptr,intmax_t => void
		[DllImport("mpir.dll", EntryPoint = "__gmpq_abs")]
        internal static extern void mpq_abs([In, Out] MPQ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_add")]
        internal static extern void mpq_add([In, Out] MPQ a0, [In] MPQ a1, [In] MPQ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_canonicalize")]
        internal static extern void mpq_canonicalize([In, Out] MPQ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_clear")]
        internal static extern void mpq_clear([In, Out] MPQ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_cmp")]
        internal static extern int mpq_cmp([In] MPQ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__g_mpq_cmp_si")]
        internal static extern int _mpq_cmp_si([In] MPQ a0, long a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__g_mpq_cmp_ui")]
        internal static extern int _mpq_cmp_ui([In] MPQ a0, ulong a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_div")]
        internal static extern void mpq_div([In, Out] MPQ a0, [In] MPQ a1, [In] MPQ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_div_2exp")]
        internal static extern void mpq_div_2exp([In, Out] MPQ a0, [In] MPQ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_equal")]
        internal static extern int mpq_equal([In] MPQ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_get_num")]
        internal static extern void mpq_get_num([In, Out] MPZ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_get_den")]
        internal static extern void mpq_get_den([In, Out] MPZ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_get_d")]
        internal static extern double mpq_get_d([In] MPQ a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_get_str")]
        internal static extern /* char* */ IntPtr mpq_get_str([MarshalAs(UnmanagedType.LPStr)] StringBuilder a0, int a1, [In] MPQ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_init")]
        internal static extern void mpq_init([In, Out] MPQ a0);
		// Skipped mpq_inp_str - mpq_ptr,FILE *,int => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpq_inv")]
        internal static extern void mpq_inv([In, Out] MPQ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_mul")]
        internal static extern void mpq_mul([In, Out] MPQ a0, [In] MPQ a1, [In] MPQ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_mul_2exp")]
        internal static extern void mpq_mul_2exp([In, Out] MPQ a0, [In] MPQ a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_neg")]
        internal static extern void mpq_neg([In, Out] MPQ a0, [In] MPQ a1);
		// Skipped mpq_out_str - FILE *,int,mpq_srcptr => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set")]
        internal static extern void mpq_set([In, Out] MPQ a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_d")]
        internal static extern void mpq_set_d([In, Out] MPQ a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_den")]
        internal static extern void mpq_set_den([In, Out] MPQ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_f")]
        internal static extern void mpq_set_f([In, Out] MPQ a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_num")]
        internal static extern void mpq_set_num([In, Out] MPQ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_si")]
        internal static extern void mpq_set_si([In, Out] MPQ a0, long a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_str")]
        internal static extern int mpq_set_str([In, Out] MPQ a0, [MarshalAs(UnmanagedType.LPStr)] string a1, int a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_ui")]
        internal static extern void mpq_set_ui([In, Out] MPQ a0, ulong a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_set_z")]
        internal static extern void mpq_set_z([In, Out] MPQ a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_sub")]
        internal static extern void mpq_sub([In, Out] MPQ a0, [In] MPQ a1, [In] MPQ a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpq_swap")]
        internal static extern void mpq_swap([In, Out] MPQ a0, [In, Out] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_abs")]
        internal static extern void mpf_abs([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_add")]
        internal static extern void mpf_add([In, Out] MPF a0, [In] MPF a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_add_ui")]
        internal static extern void mpf_add_ui([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_ceil")]
        internal static extern void mpf_ceil([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_clear")]
        internal static extern void mpf_clear([In, Out] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_cmp")]
        internal static extern int mpf_cmp([In] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_cmp_d")]
        internal static extern int mpf_cmp_d([In] MPF a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_cmp_si")]
        internal static extern int mpf_cmp_si([In] MPF a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_cmp_ui")]
        internal static extern int mpf_cmp_ui([In] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_div")]
        internal static extern void mpf_div([In, Out] MPF a0, [In] MPF a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_div_2exp")]
        internal static extern void mpf_div_2exp([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_div_ui")]
        internal static extern void mpf_div_ui([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_dump")]
        internal static extern void mpf_dump([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_eq")]
        internal static extern int mpf_eq([In] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_sint_p")]
        internal static extern int mpf_fits_sint_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_si_p")]
        internal static extern int mpf_fits_si_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_slong_p")]
        internal static extern int mpf_fits_slong_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_sshort_p")]
        internal static extern int mpf_fits_sshort_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_uint_p")]
        internal static extern int mpf_fits_uint_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_ui_p")]
        internal static extern int mpf_fits_ui_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_ulong_p")]
        internal static extern int mpf_fits_ulong_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_fits_ushort_p")]
        internal static extern int mpf_fits_ushort_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_floor")]
        internal static extern void mpf_floor([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_get_d")]
        internal static extern double mpf_get_d([In] MPF a0);
		// Skipped mpf_get_d_2exp - signed long *,mpf_srcptr => double
		// Skipped mpf_get_default_prec - void => mp_bitcnt_t
		// Skipped mpf_get_prec - mpf_srcptr => mp_bitcnt_t
		// Skipped mpf_get_si - mpf_srcptr => mpir_si
		// Skipped mpf_get_str - char *,mp_exp_t *,int,size_t,mpf_srcptr => char *
		[DllImport("mpir.dll", EntryPoint = "__gmpf_get_ui")]
        internal static extern ulong mpf_get_ui([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init")]
        internal static extern void mpf_init([In, Out] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init2")]
        internal static extern void mpf_init2([In, Out] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init_set")]
        internal static extern void mpf_init_set([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init_set_d")]
        internal static extern void mpf_init_set_d([In, Out] MPF a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init_set_si")]
        internal static extern void mpf_init_set_si([In, Out] MPF a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init_set_str")]
        internal static extern int mpf_init_set_str([In, Out] MPF a0, [MarshalAs(UnmanagedType.LPStr)] string a1, int a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_init_set_ui")]
        internal static extern void mpf_init_set_ui([In, Out] MPF a0, ulong a1);
		// Skipped mpf_inp_str - mpf_ptr,FILE *,int => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpf_integer_p")]
        internal static extern int mpf_integer_p([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_mul")]
        internal static extern void mpf_mul([In, Out] MPF a0, [In] MPF a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_mul_2exp")]
        internal static extern void mpf_mul_2exp([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_mul_ui")]
        internal static extern void mpf_mul_ui([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_neg")]
        internal static extern void mpf_neg([In, Out] MPF a0, [In] MPF a1);
		// Skipped mpf_out_str - FILE *,int,size_t,mpf_srcptr => size_t
		[DllImport("mpir.dll", EntryPoint = "__gmpf_pow_ui")]
        internal static extern void mpf_pow_ui([In, Out] MPF a0, [In] MPF a1, ulong a2);
		// Skipped mpf_random2 - mpf_ptr,mp_size_t,mp_exp_t => void
		// Skipped mpf_rrandomb - mpf_ptr,gmp_randstate_t,mp_size_t,mp_exp_t => void
		[DllImport("mpir.dll", EntryPoint = "__gmpf_reldiff")]
        internal static extern void mpf_reldiff([In, Out] MPF a0, [In] MPF a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set")]
        internal static extern void mpf_set([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_d")]
        internal static extern void mpf_set_d([In, Out] MPF a0, double a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_default_prec")]
        internal static extern void mpf_set_default_prec(ulong a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_prec")]
        internal static extern void mpf_set_prec([In, Out] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_prec_raw")]
        internal static extern void mpf_set_prec_raw([In, Out] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_q")]
        internal static extern void mpf_set_q([In, Out] MPF a0, [In] MPQ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_si")]
        internal static extern void mpf_set_si([In, Out] MPF a0, long a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_str")]
        internal static extern int mpf_set_str([In, Out] MPF a0, [MarshalAs(UnmanagedType.LPStr)] string a1, int a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_ui")]
        internal static extern void mpf_set_ui([In, Out] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_set_z")]
        internal static extern void mpf_set_z([In, Out] MPF a0, [In] MPZ a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_size")]
        internal static extern ulong mpf_size([In] MPF a0);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_sqrt")]
        internal static extern void mpf_sqrt([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_sqrt_ui")]
        internal static extern void mpf_sqrt_ui([In, Out] MPF a0, ulong a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_sub")]
        internal static extern void mpf_sub([In, Out] MPF a0, [In] MPF a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_sub_ui")]
        internal static extern void mpf_sub_ui([In, Out] MPF a0, [In] MPF a1, ulong a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_swap")]
        internal static extern void mpf_swap([In, Out] MPF a0, [In, Out] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_trunc")]
        internal static extern void mpf_trunc([In, Out] MPF a0, [In] MPF a1);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_ui_div")]
        internal static extern void mpf_ui_div([In, Out] MPF a0, ulong a1, [In] MPF a2);
		[DllImport("mpir.dll", EntryPoint = "__gmpf_ui_sub")]
        internal static extern void mpf_ui_sub([In, Out] MPF a0, ulong a1, [In] MPF a2);
		// Skipped mpf_urandomb - mpf_t,gmp_randstate_t,mp_bitcnt_t => void
		// Skipped mpn_add - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_add_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_add_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_addmul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_bdivmod - mp_ptr,mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mpir_ui => mp_limb_t
		// Skipped mpn_divrem - mp_ptr,mp_size_t,mp_ptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_mulmod_Bexpp1 - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t,mp_ptr => int
		// Skipped mpn_mulmod_2expp1 - mp_ptr,mp_srcptr,mp_srcptr,int,mpir_ui,mp_ptr => int
		// Skipped mpn_mulmod_2expm1 - mp_ptr,mp_ptr,mp_ptr,mpir_ui,mp_ptr => void
		// Skipped mpn_cmp - mp_srcptr,mp_srcptr,mp_size_t => int
		// Skipped mpn_redc_2 - mp_ptr,mp_ptr,mp_srcptr,mp_size_t,mp_srcptr => void
		// Skipped mpn_redc_n - mp_ptr,mp_ptr,mp_srcptr,mp_size_t,mp_srcptr => void
		// Skipped mpn_divexact_by3c - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_divrem_1 - mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_divrem_2 - mp_ptr,mp_size_t,mp_ptr,mp_size_t,mp_srcptr => mp_limb_t
		// Skipped mpn_invert - mp_ptr xp,mp_srcptr ap,mp_size_t n => void
		// Skipped mpn_gcd - mp_ptr,mp_ptr,mp_size_t,mp_ptr,mp_size_t => mp_size_t
		// Skipped mpn_gcd_1 - mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_gcdext_1 - mp_limb_signed_t *,mp_limb_signed_t *,mp_limb_t,mp_limb_t => mp_limb_t
		// Skipped mpn_gcdext - mp_ptr,mp_ptr,mp_size_t *,mp_ptr,mp_size_t,mp_ptr,mp_size_t => mp_size_t
		// Skipped mpn_get_str - unsigned char *,int,mp_ptr,mp_size_t => size_t
		// Skipped mpn_hamdist - mp_srcptr,mp_srcptr,mp_size_t => mp_bitcnt_t
		// Skipped mpn_lshift - mp_ptr,mp_srcptr,mp_size_t,unsigned int => mp_limb_t
		// Skipped mpn_mod_1 - mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_mul - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_mul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_mul_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_sqr - mp_ptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_neg_n - mp_ptr,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_com_n - mp_ptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_perfect_square_p - mp_srcptr,mp_size_t => int
		// Skipped mpn_popcount - mp_srcptr,mp_size_t => mp_bitcnt_t
		// Skipped mpn_pow_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t,mp_ptr => mp_size_t
		// Skipped mpn_preinv_mod_1 - mp_srcptr,mp_size_t,mp_limb_t,mp_limb_t => mp_limb_t
		// Skipped mpn_random - mp_ptr,mp_size_t => void
		// Skipped mpn_random2 - mp_ptr,mp_size_t => void
		// Skipped mpn_urandomb - mp_ptr,gmp_randstate_t,mpir_ui => void
		// Skipped mpn_urandomm - mp_ptr,gmp_randstate_t,mp_srcptr,mp_size_t => void
		// Skipped mpn_randomb - mp_ptr,gmp_randstate_t,mp_size_t => void
		// Skipped mpn_rrandom - mp_ptr,gmp_randstate_t,mp_size_t => void
		// Skipped mpn_rshift - mp_ptr,mp_srcptr,mp_size_t,unsigned int => mp_limb_t
		// Skipped mpn_scan0 - mp_srcptr,mp_bitcnt_t => mp_bitcnt_t
		// Skipped mpn_scan1 - mp_srcptr,mp_bitcnt_t => mp_bitcnt_t
		// Skipped mpn_set_str - mp_ptr,__gmp_const unsigned char *,size_t,int => mp_size_t
		// Skipped mpn_sqrtrem - mp_ptr,mp_ptr,mp_srcptr,mp_size_t => mp_size_t
		// Skipped mpn_sub - mp_ptr,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_sub_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_sub_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_submul_1 - mp_ptr,mp_srcptr,mp_size_t,mp_limb_t => mp_limb_t
		// Skipped mpn_tdiv_qr - mp_ptr,mp_ptr,mp_size_t,mp_srcptr,mp_size_t,mp_srcptr,mp_size_t => void
		// Skipped mpn_and_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_andn_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_nand_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_ior_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_iorn_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_nior_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_xor_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_xnor_n - mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_copyi - mp_ptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_copyd - mp_ptr,mp_srcptr,mp_size_t => void
		// Skipped mpn_zero - mp_ptr,mp_size_t => void
		// Skipped mpn_sumdiff_n - mp_ptr,mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_nsumdiff_n - mp_ptr,mp_ptr,mp_srcptr,mp_srcptr,mp_size_t => mp_limb_t
		// Skipped mpn_mul_fft_main - mp_ptr r1,mp_srcptr i1,mp_size_t n1,mp_srcptr i2,mp_size_t n2 => void
		// Skipped mpn_mul_fft - mp_ptr rp,mp_size_t rn,mp_srcptr ap,mp_size_t an,mp_srcptr bp,mp_size_t bn,int k => int
    }
}
